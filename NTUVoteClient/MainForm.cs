using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private int pingCounter = 0;

        public MainForm()
        {
            InitializeComponent();

            pingApiClient = new ApiClient();
            pingApiClient.DownloadDataCompleted += OnPingCompleted;

            authApiClient = new ApiClient();
            authApiClient.UploadValuesCompleted += OnAuthCompleted;

            this.FormClosing += OnThisFormClosing;
            scanButton.Click += OnScanButtonClick;

            pingTimer.Interval -= new Random().Next(100);
            pingTimer.Tick += OnTimerTick;
            pingTimer.Start();

            pingApiClient.SendRequestAsync("account/booth");
        }

        protected void OnTimerTick(object sender, EventArgs e)
        {
            pingCounter = (pingCounter + 1) % 5;
            if (pingCounter == 1) {
                if (pingApiClient.IsBusy) pingApiClient.CancelAsync();
                if (networkStatusLabel.Text != "線上")
                    networkStatusLabel.Text = "正在連線";
                pingApiClient.SendRequestAsync("account/booth");
            }

            if (boothPanels != null)
                foreach (BoothPanel panel in boothPanels)
                    panel.UpdateTimer();
        }

        protected void OnPingCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if (e.Error != null) {
                Program.Log(e.Error);
                networkStatusLabel.Text = "斷線";
            } else {
                networkStatusLabel.Text = "線上";

                // Parse and load the reply
                JObject entity = ApiClient.ParseJson(e.Result);

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

                Program.Log(String.Format("Updated election status {0}", status));

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
                JObject boothStatus = (JObject) entity["booths"];
                foreach (JProperty item in boothStatus.Properties()) {
                    int boothId = int.Parse(item.Name);
                    BoothPanel panel = boothPanels[boothId - 1];
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
            scanButton.Enabled = true;
            if (e.Cancelled) return;
            if (e.Error != null) {
                ApiError error = ApiClient.ParseError(e.Error);
                if (error == null)
                    Program.ShowError(this, e.Error, "驗證失敗");
                else {
                    Program.ShowError(this, "無法完成驗證。（錯誤代碼：{0}）", "驗證失敗", error.Code);
                }

            } else {
                // Create a new AuthenticateForm
                AuthenticateForm authForm = new AuthenticateForm();

                // Parse and load the reply
                JObject entity = ApiClient.ParseJson(e.Result);
                string studentIdWithRev = (string) e.UserState;

                authForm.StudentId = studentIdWithRev.Substring(0, 9);
                authForm.Revision = studentIdWithRev.Substring(9);
                authForm.College = (string) entity["college"];
                authForm.Department = (string) entity["department"];
                authForm.BallotNames = String.Join("\n", from s in entity["ballots"] select (string) s);
                authForm.SessionKey = (string) entity["session_key"];
                authForm.BoothAllocated += OnBoothAllocated;
                authForm.Cancelled += OnAuthCancelled;

                // Show the form
                authForm.ShowDialog(this);
            }
        }

        protected void OnBoothAllocated(object sender, BoothAllocatedEventArgs e)
        {
            RecordPanel record = new RecordPanel();
            record.StudentId = e.StudentId;
            record.Status = String.Format("{0} 號平板", e.BoothId);
            recordLayout.Controls.Add(record);
            recordLayout.Controls.SetChildIndex(record, 0);

            boothPanels[e.BoothId - 1].LastUpdated = DateTime.Now;
        }

        protected void OnAuthCancelled(object sender, EventArgs e)
        {
            AuthenticateForm authForm = (AuthenticateForm) sender;
            RecordPanel record = new RecordPanel();
            record.StudentId = authForm.StudentId;
            record.Status = "取消";
            recordLayout.Controls.Add(record);
            recordLayout.Controls.SetChildIndex(record, 0);
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
            scanButton.Enabled = false;
        }
    }
}
