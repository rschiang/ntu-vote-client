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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            scanButton.Click += OnScanButtonClick;
            this.FormClosing += OnThisFormClosing;
        }

        private void OnThisFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OnScanButtonClick(object sender, EventArgs e)
        {
            AuthenticateForm form = new AuthenticateForm();
            form.ShowDialog(this);
        }
    }
}
