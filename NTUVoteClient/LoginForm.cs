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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginButton.Click += OnLoginButtonClick;
        }

        protected void OnLoginButtonClick(Object sender, EventArgs args)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
