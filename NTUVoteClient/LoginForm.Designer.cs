namespace NTUOSC.Vote
{
    partial class LoginForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(20, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "登入選務系統";
            //
            // hintLabel
            //
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(24, 120);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(188, 16);
            this.hintLabel.TabIndex = 1;
            this.hintLabel.Text = "輸入選務中心配發的帳號與密碼。";
            //
            // usernameLabel
            //
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(24, 156);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 16);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "使用者名稱";
            //
            // usernameField
            //
            this.usernameField.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.usernameField.Location = new System.Drawing.Point(27, 180);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(330, 23);
            this.usernameField.TabIndex = 3;
            //
            // passwordLabel
            //
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(24, 216);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(32, 16);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "密碼";
            //
            // passwordField
            //
            this.passwordField.Location = new System.Drawing.Point(27, 240);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(330, 23);
            this.passwordField.TabIndex = 5;
            this.passwordField.UseSystemPasswordChar = true;
            //
            // loginButton
            //
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginButton.Enabled = false;
            this.loginButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(27, 360);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(330, 30);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "登入";
            this.loginButton.UseVisualStyleBackColor = true;
            //
            // LoginForm
            //
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 409);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTUVote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginButton;
    }
}
