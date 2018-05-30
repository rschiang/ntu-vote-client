using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace NTUOSC.Vote
{
    public partial class MainForm : Form
    {
        private bool initialized = false;
        private ApiClient pingApiClient;
        private ApiClient authApiClient;
        private BoothPanel[] boothPanels;

        public MainForm()
        {
            InitializeComponent();

            pingApiClient = new ApiClient();
            pingApiClient.UploadValuesCompleted += OnPingCompleted;

            authApiClient = new ApiClient();
            authApiClient.UploadValuesCompleted += OnAuthCompleted;

            this.FormClosing += OnThisFormClosing;
            scanButton.Click += OnScanButtonClick;
        }

        protected void OnPingCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            if (e.Error != null) {
                Program.Log(e);
                networkStatusLabel.Text = "斷線";
            } else {
                networkStatusLabel.Text = "線上";

                // Parse and load the reply
                JObject entity = ApiClient.ParseJson(e.Reply);

                string status = (string) entity["election"];
                switch (status) {
                    case "started":
                        electionStatusLabel.Text = "開放投票中"; break;
                    case "paused":
                        electionStatusLabel.Text = "投票暫停"; break;
                    case "stopped":
                        electionStatusLabel.Text = "結束投票"; break;
                    default:
                        electionStatusLabel.Text = "尚未開始"; break;
                }

                Program.Log(String.Format("Updated election status {0}", status))

                if (!initialized) {
                    // Loads the booth name during initialization
                    titleLabel.Text = (string) entity["station"];
                    descriptionLabel.Text = (string) entity["description"];

                    // Iterate through and create booth panels
                    boothPanels = new BoothPanel[4];
                    for (int i = 0; i < 4; i++) {
                        boothPanels[i] = new BoothPanel(boothLayout, i + 1);
                    }

                    initialized = true;
                }

                // Loads booth status
                foreach (JProperty item in entity["booths"].Properties()) {
                    BoothPanel panel = boothPanels[(int)item.Key - 1];
                    switch ((string) item.Value) {
                        case "in_use":
                            panel.State = BoothPanel.States.InUse; break;
                        case "available":
                            panel.State = BoothPanel.States.Available; break;
                        default:
                            panel.State = BoothPanel.States.Offline; break;
                    }
                }
            }
        }

        protected void OnAuthCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            if (e.Error != null) {
                Program.Log(e);
                MessageBox.Show(this, ApiClient.GetErrorMessage(e.Error)), "驗證失敗",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                // Create a new AuthenticateForm
                AuthenticateForm authForm = new AuthenticateForm();

                // Parse and load the reply
                JObject entity = ApiClient.ParseJson(e.Reply);
                string studentIdWithRev = (string) e.UserState;

                authForm.StudentId = studentIdWithRev.Substring(0, 9);
                authForm.Revision = studentIdWithRev.Substring(9);
                authForm.College = (string) entity["college"];
                authForm.Department = (string) entity["department"];
                authForm.BallotNames = String.Join("\n", from s in entity["ballots"] select (string) s);
                authForm.SessionKey = (string) entity["session_key"];

                // Show the form
                authForm.ShowDialog(this);
            }
        }

        protected void OnThisFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "確定要退出選務系統嗎？", "確認登出",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                                                  MessageBoxDefaultButton.Button2);
            if (result != DialogResult.OK)
                e.Cancel = true;
        }

        protected void OnScanButtonClick(object sender, EventArgs e)
        {
            // TODO: Scan card
            string internalId = "00000000";
            string studentId = "B02A01199";
            string revision = "1";

            NameValueCollection values = new NameValueCollection();
            values["internal_id"] = internalId;
            values["student_id"] = studentId;
            values["revision"] = revision;

            authApiClient.SendRequestAsync(ApiClient.FormatApiPath("authenticate"), values, studentId + revision);
        }
    }
}
