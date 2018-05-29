namespace NTUOSC.Vote
{
    partial class AuthenticateForm
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
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.studentIdField = new System.Windows.Forms.Label();
            this.collegeField = new System.Windows.Forms.Label();
            this.revisionField = new System.Windows.Forms.Label();
            this.revisionLabel = new System.Windows.Forms.Label();
            this.ballotField = new System.Windows.Forms.Label();
            this.ballotLabel = new System.Windows.Forms.Label();
            this.rejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(20, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(145, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "驗證身分";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(24, 120);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(452, 16);
            this.hintLabel.TabIndex = 1;
            this.hintLabel.Text = "請與選舉人核對學號、學院、票種是否正確；確認選舉人身分後，將無法復行變更。";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.studentIdLabel.Location = new System.Drawing.Point(24, 156);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(68, 16);
            this.studentIdLabel.TabIndex = 2;
            this.studentIdLabel.Text = "選舉人學號";
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.collegeLabel.Location = new System.Drawing.Point(24, 216);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(56, 16);
            this.collegeLabel.TabIndex = 4;
            this.collegeLabel.Text = "所屬學院";
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.confirmButton.Location = new System.Drawing.Point(27, 429);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(6);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(158, 30);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "確認身分並派票";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // studentIdField
            // 
            this.studentIdField.AutoSize = true;
            this.studentIdField.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.studentIdField.Location = new System.Drawing.Point(23, 178);
            this.studentIdField.Margin = new System.Windows.Forms.Padding(6);
            this.studentIdField.Name = "studentIdField";
            this.studentIdField.Size = new System.Drawing.Size(113, 24);
            this.studentIdField.TabIndex = 7;
            this.studentIdField.Text = "B02A01199";
            // 
            // collegeField
            // 
            this.collegeField.AutoSize = true;
            this.collegeField.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.collegeField.Location = new System.Drawing.Point(23, 238);
            this.collegeField.Margin = new System.Windows.Forms.Padding(6);
            this.collegeField.Name = "collegeField";
            this.collegeField.Size = new System.Drawing.Size(162, 24);
            this.collegeField.TabIndex = 8;
            this.collegeField.Text = "生物資源暨農學院";
            // 
            // revisionField
            // 
            this.revisionField.AutoSize = true;
            this.revisionField.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.revisionField.Location = new System.Drawing.Point(23, 298);
            this.revisionField.Margin = new System.Windows.Forms.Padding(6);
            this.revisionField.Name = "revisionField";
            this.revisionField.Size = new System.Drawing.Size(32, 24);
            this.revisionField.TabIndex = 10;
            this.revisionField.Text = "10";
            // 
            // revisionLabel
            // 
            this.revisionLabel.AutoSize = true;
            this.revisionLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.revisionLabel.Location = new System.Drawing.Point(24, 276);
            this.revisionLabel.Name = "revisionLabel";
            this.revisionLabel.Size = new System.Drawing.Size(92, 16);
            this.revisionLabel.TabIndex = 9;
            this.revisionLabel.Text = "學生證補發次數";
            // 
            // ballotField
            // 
            this.ballotField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ballotField.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ballotField.Location = new System.Drawing.Point(215, 178);
            this.ballotField.Margin = new System.Windows.Forms.Padding(6);
            this.ballotField.Name = "ballotField";
            this.ballotField.Size = new System.Drawing.Size(375, 239);
            this.ballotField.TabIndex = 12;
            this.ballotField.Text = "學生會長\r\n法律學院學生代表\r\n法律系系學會長\r\n性平會學生委員\r\n宿舍生治會幹事\r\n臺大校長";
            // 
            // ballotLabel
            // 
            this.ballotLabel.AutoSize = true;
            this.ballotLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.ballotLabel.Location = new System.Drawing.Point(216, 156);
            this.ballotLabel.Name = "ballotLabel";
            this.ballotLabel.Size = new System.Drawing.Size(56, 16);
            this.ballotLabel.TabIndex = 11;
            this.ballotLabel.Text = "可投票種";
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rejectButton.Location = new System.Drawing.Point(197, 429);
            this.rejectButton.Margin = new System.Windows.Forms.Padding(6);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(158, 30);
            this.rejectButton.TabIndex = 13;
            this.rejectButton.Text = "取消";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // AuthenticateForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.rejectButton;
            this.ClientSize = new System.Drawing.Size(620, 489);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.ballotField);
            this.Controls.Add(this.ballotLabel);
            this.Controls.Add(this.revisionField);
            this.Controls.Add(this.revisionLabel);
            this.Controls.Add(this.collegeField);
            this.Controls.Add(this.studentIdField);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.collegeLabel);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthenticateForm";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTUVote";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label studentIdField;
        private System.Windows.Forms.Label collegeField;
        private System.Windows.Forms.Label revisionField;
        private System.Windows.Forms.Label revisionLabel;
        private System.Windows.Forms.Label ballotField;
        private System.Windows.Forms.Label ballotLabel;
        private System.Windows.Forms.Button rejectButton;
    }
}

