using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NTUOSC.Vote
{
    public partial class AuthenticateForm : Form
    {
        public event EventHandler<BoothAllocatedEventArgs> BoothAllocated;
        public event EventHandler Cancelled;
        private bool isCanceling = false;
        private ApiClient apiClient;

        public AuthenticateForm()
        {
            InitializeComponent();

            apiClient = new ApiClient();
            apiClient.UploadValuesCompleted += OnVerifyCompleted;

            confirmButton.Click += OnConfirmButtonClick;
            cancelButton.Click += OnCancelButtonClick;
            this.FormClosing += OnThisFormClosing;
        }

        private void OnThisFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCanceling) e.Cancel = true;
        }

        protected void OnVerifyCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            // Only process the response if we are not closing the dialog.
            if (!isCanceling) {
                if (e.Error != null) {  // Check if allocation succeeded
                    ApiError error = ApiClient.ParseError(e.Error);
                    if (error != null) {
                        Program.ShowError(this, "目前所有票亭都在忙碌中。（錯誤代碼：{0}）", "派票不成功", error.Code);
                    } else {
                        Program.ShowError(this, e.Error, "派票不成功");
                    }
                    
                    return;
                } else {
                    // Allocation succeeded
                    int boothId = (int) ApiClient.ParseJson(e.Result)["booth_id"];
                    OnBoothAllocated(boothId);
                    MessageBox.Show(this, String.Format("請至 {0} 號平板投票。", boothId), "派票成功", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else OnCancelled();

            this.Close();
        }

        protected void OnConfirmButtonClick(Object sender, EventArgs args)
        {
            NameValueCollection values = new NameValueCollection {
                ["student_id"] = StudentId,
                ["session_key"] = SessionKey
            };
            apiClient.SendRequestAsync(ApiClient.FormatApiPath("allocate"), values);
            confirmButton.Enabled = cancelButton.Enabled = false;
        }

        protected void OnCancelButtonClick(Object sender, EventArgs args)
        {
            NameValueCollection values = new NameValueCollection {
                ["student_id"] = StudentId,
                ["session_key"] = SessionKey
            };
            apiClient.SendRequestAsync(ApiClient.FormatApiPath("cancel"), values);
            confirmButton.Enabled = cancelButton.Enabled = false;
            isCanceling = true;
        }

        protected void OnBoothAllocated(int boothId)
        {
            EventHandler<BoothAllocatedEventArgs> handler = BoothAllocated;
            BoothAllocatedEventArgs e = new BoothAllocatedEventArgs(StudentId, boothId);
            if (handler != null)
                handler(this, e);
        }

        protected void OnCancelled()
        {
            EventHandler handler = Cancelled;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public string StudentId
        {
            get { return studentIdField.Text; }
            set { studentIdField.Text = value; }
        }

        public string Revision
        {
            get { return revisionField.Text; }
            set { revisionField.Text = value; }
        }

        public string College
        {
            get { return collegeField.Text; }
            set { collegeField.Text = value; }
        }

        public string Department { get; set; }

        public string BallotNames
        {
            get { return ballotField.Text; }
            set { ballotField.Text = value; }
        }

        public string SessionKey { get; set; }
    }

    public class BoothAllocatedEventArgs : EventArgs
    {
        public BoothAllocatedEventArgs(string studentId, int boothId)
        {
            StudentId = studentId;
            BoothId = boothId;
        }

        public string StudentId { get; set; }
        public int BoothId { get; set; }
    }
}
