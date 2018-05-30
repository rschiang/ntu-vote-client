using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTUOSC.Vote
{
    public partial class AuthenticateForm : Form
    {
        public AuthenticateForm()
        {
            InitializeComponent();
            confirmButton.Click += OnConfirmButtonClick;
        }

        protected void OnConfirmButtonClick(Object sender, EventArgs args)
        {
            this.Close();
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
}
