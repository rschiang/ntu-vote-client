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
    public partial class LoginForm : Form
    {
        public event EventHandler LoginSucceeded;
        private ApiClient apiClient;

        public LoginForm()
        {
            InitializeComponent();

            apiClient = new ApiClient();
            apiClient.UploadValuesCompleted += OnUploadValuesCompleted;

            loginButton.Click += OnLoginButtonClick;
            usernameField.TextChanged += OnFieldTextChanged;
            passwordField.TextChanged += OnFieldTextChanged;
        }

        protected void OnFieldTextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = (usernameField.TextLength > 0) && (passwordField.TextLength > 0);
        }

        protected void OnLoginButtonClick(object sender, EventArgs e)
        {
            NameValueCollection values = new NameValueCollection();
            values["username"] = usernameField.Text;
            values["password"] = passwordField.Text;
            apiClient.SendRequestAsync("account/register", values);
        }

        protected void OnUploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            if (e.Error != null) {
                ApiError error = ApiClient.ParseError(e.Error);
                if (error != null)
                    Program.ShowError(this, "請確認帳號密碼是否正確。（錯誤代碼：{0}）", "登入失敗", error.Code);
                else
                    Program.ShowError(this, e.Error, "登入失敗");
            } else {
                // Parse and load the token
                string token = (string) ApiClient.ParseJson(e.Result)["token"];
                ApiClient.SetToken(token);

                OnLoginSucceeded(null);
                this.Close();
            }
        }

        protected virtual void OnLoginSucceeded(EventArgs e)
        {
            EventHandler handler = LoginSucceeded;
            if (handler != null)
                handler(this, e);
        }
    }
}
