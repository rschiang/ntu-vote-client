namespace NTUOSC.Vote
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.electionStatusLabel = new System.Windows.Forms.Label();
            this.networkStatusLabel = new System.Windows.Forms.Label();
            this.boothLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.examplePanel1 = new System.Windows.Forms.Panel();
            this.examplePanel2 = new System.Windows.Forms.Panel();
            this.examplePanel3 = new System.Windows.Forms.Panel();
            this.examplePanel4 = new System.Windows.Forms.Panel();
            this.boothNumberlabel1 = new System.Windows.Forms.Label();
            this.boothNumberLabel2 = new System.Windows.Forms.Label();
            this.boothNumberLabel3 = new System.Windows.Forms.Label();
            this.boothNumberLabel4 = new System.Windows.Forms.Label();
            this.boothStatLabel1 = new System.Windows.Forms.Label();
            this.boothStatLabel2 = new System.Windows.Forms.Label();
            this.boothStatLabel3 = new System.Windows.Forms.Label();
            this.boothStatLabel4 = new System.Windows.Forms.Label();
            this.boothTimerLabel = new System.Windows.Forms.Label();
            this.authPanel = new System.Windows.Forms.GroupBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.scanHintButton = new System.Windows.Forms.Label();
            this.recordLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.recordEntry = new System.Windows.Forms.Panel();
            this.recordStudentIdLabel = new System.Windows.Forms.Label();
            this.recordStatusLabel = new System.Windows.Forms.Label();
            this.boothLayout.SuspendLayout();
            this.examplePanel1.SuspendLayout();
            this.examplePanel2.SuspendLayout();
            this.examplePanel3.SuspendLayout();
            this.examplePanel4.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.recordEntry.SuspendLayout();
            this.SuspendLayout();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 30F);
            this.titleLabel.Location = new System.Drawing.Point(30, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(102, 50);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "傅鐘";
            //
            // descriptionLabel
            //
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descriptionLabel.Location = new System.Drawing.Point(36, 84);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(232, 18);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "貢獻大學於宇宙之精神的歡樂投票所";
            //
            // electionStatusLabel
            //
            this.electionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.electionStatusLabel.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.electionStatusLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.electionStatusLabel.Location = new System.Drawing.Point(691, 30);
            this.electionStatusLabel.Name = "electionStatusLabel";
            this.electionStatusLabel.Size = new System.Drawing.Size(160, 27);
            this.electionStatusLabel.TabIndex = 3;
            this.electionStatusLabel.Text = "尚未開始";
            this.electionStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // networkStatusLabel
            //
            this.networkStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.networkStatusLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.networkStatusLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.networkStatusLabel.Location = new System.Drawing.Point(692, 57);
            this.networkStatusLabel.Name = "networkStatusLabel";
            this.networkStatusLabel.Size = new System.Drawing.Size(156, 24);
            this.networkStatusLabel.TabIndex = 4;
            this.networkStatusLabel.Text = "離線";
            this.networkStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // boothLayout
            //
            this.boothLayout.Controls.Add(this.examplePanel1);
            this.boothLayout.Controls.Add(this.examplePanel2);
            this.boothLayout.Controls.Add(this.examplePanel3);
            this.boothLayout.Controls.Add(this.examplePanel4);
            this.boothLayout.Location = new System.Drawing.Point(39, 120);
            this.boothLayout.Margin = new System.Windows.Forms.Padding(24);
            this.boothLayout.Name = "boothLayout";
            this.boothLayout.Size = new System.Drawing.Size(372, 414);
            this.boothLayout.TabIndex = 5;
            //
            // examplePanel1
            //
            this.examplePanel1.BackColor = System.Drawing.Color.LightGreen;
            this.examplePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examplePanel1.Controls.Add(this.boothTimerLabel);
            this.examplePanel1.Controls.Add(this.boothStatLabel1);
            this.examplePanel1.Controls.Add(this.boothNumberlabel1);
            this.examplePanel1.Location = new System.Drawing.Point(3, 3);
            this.examplePanel1.Name = "examplePanel1";
            this.examplePanel1.Size = new System.Drawing.Size(180, 180);
            this.examplePanel1.TabIndex = 1;
            //
            // examplePanel2
            //
            this.examplePanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.examplePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examplePanel2.Controls.Add(this.boothStatLabel2);
            this.examplePanel2.Controls.Add(this.boothNumberLabel2);
            this.examplePanel2.Location = new System.Drawing.Point(189, 3);
            this.examplePanel2.Name = "examplePanel2";
            this.examplePanel2.Size = new System.Drawing.Size(180, 180);
            this.examplePanel2.TabIndex = 2;
            //
            // examplePanel3
            //
            this.examplePanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.examplePanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examplePanel3.Controls.Add(this.boothStatLabel3);
            this.examplePanel3.Controls.Add(this.boothNumberLabel3);
            this.examplePanel3.Location = new System.Drawing.Point(3, 189);
            this.examplePanel3.Name = "examplePanel3";
            this.examplePanel3.Size = new System.Drawing.Size(180, 180);
            this.examplePanel3.TabIndex = 3;
            //
            // examplePanel4
            //
            this.examplePanel4.BackColor = System.Drawing.Color.LightGray;
            this.examplePanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examplePanel4.Controls.Add(this.boothStatLabel4);
            this.examplePanel4.Controls.Add(this.boothNumberLabel4);
            this.examplePanel4.Location = new System.Drawing.Point(189, 189);
            this.examplePanel4.Name = "examplePanel4";
            this.examplePanel4.Size = new System.Drawing.Size(180, 180);
            this.examplePanel4.TabIndex = 4;
            //
            // boothNumberlabel1
            //
            this.boothNumberlabel1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.boothNumberlabel1.Location = new System.Drawing.Point(3, 3);
            this.boothNumberlabel1.Name = "boothNumberlabel1";
            this.boothNumberlabel1.Size = new System.Drawing.Size(174, 18);
            this.boothNumberlabel1.TabIndex = 0;
            this.boothNumberlabel1.Text = "1";
            this.boothNumberlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothNumberLabel2
            //
            this.boothNumberLabel2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.boothNumberLabel2.Location = new System.Drawing.Point(3, 3);
            this.boothNumberLabel2.Name = "boothNumberLabel2";
            this.boothNumberLabel2.Size = new System.Drawing.Size(174, 18);
            this.boothNumberLabel2.TabIndex = 1;
            this.boothNumberLabel2.Text = "2";
            this.boothNumberLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothNumberLabel3
            //
            this.boothNumberLabel3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.boothNumberLabel3.Location = new System.Drawing.Point(3, 3);
            this.boothNumberLabel3.Name = "boothNumberLabel3";
            this.boothNumberLabel3.Size = new System.Drawing.Size(174, 18);
            this.boothNumberLabel3.TabIndex = 1;
            this.boothNumberLabel3.Text = "3";
            this.boothNumberLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothNumberLabel4
            //
            this.boothNumberLabel4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.boothNumberLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.boothNumberLabel4.Location = new System.Drawing.Point(3, 3);
            this.boothNumberLabel4.Name = "boothNumberLabel4";
            this.boothNumberLabel4.Size = new System.Drawing.Size(174, 18);
            this.boothNumberLabel4.TabIndex = 1;
            this.boothNumberLabel4.Text = "4";
            this.boothNumberLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothStatLabel1
            //
            this.boothStatLabel1.Location = new System.Drawing.Point(3, 158);
            this.boothStatLabel1.Name = "boothStatLabel1";
            this.boothStatLabel1.Size = new System.Drawing.Size(174, 18);
            this.boothStatLabel1.TabIndex = 1;
            this.boothStatLabel1.Text = "投票中";
            this.boothStatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothStatLabel2
            //
            this.boothStatLabel2.Location = new System.Drawing.Point(3, 158);
            this.boothStatLabel2.Name = "boothStatLabel2";
            this.boothStatLabel2.Size = new System.Drawing.Size(174, 18);
            this.boothStatLabel2.TabIndex = 2;
            this.boothStatLabel2.Text = "閒置";
            this.boothStatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothStatLabel3
            //
            this.boothStatLabel3.Location = new System.Drawing.Point(3, 158);
            this.boothStatLabel3.Name = "boothStatLabel3";
            this.boothStatLabel3.Size = new System.Drawing.Size(174, 18);
            this.boothStatLabel3.TabIndex = 3;
            this.boothStatLabel3.Text = "閒置";
            this.boothStatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothStatLabel4
            //
            this.boothStatLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.boothStatLabel4.Location = new System.Drawing.Point(3, 158);
            this.boothStatLabel4.Name = "boothStatLabel4";
            this.boothStatLabel4.Size = new System.Drawing.Size(174, 18);
            this.boothStatLabel4.TabIndex = 4;
            this.boothStatLabel4.Text = "離線";
            this.boothStatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // boothTimerLabel
            //
            this.boothTimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boothTimerLabel.Font = new System.Drawing.Font("微軟正黑體", 42F);
            this.boothTimerLabel.Location = new System.Drawing.Point(3, 21);
            this.boothTimerLabel.Name = "boothTimerLabel";
            this.boothTimerLabel.Size = new System.Drawing.Size(172, 137);
            this.boothTimerLabel.TabIndex = 2;
            this.boothTimerLabel.Text = "64";
            this.boothTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // authPanel
            //
            this.authPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authPanel.Controls.Add(this.recordEntry);
            this.authPanel.Controls.Add(this.recordLayout);
            this.authPanel.Controls.Add(this.scanHintButton);
            this.authPanel.Controls.Add(this.scanButton);
            this.authPanel.Location = new System.Drawing.Point(438, 120);
            this.authPanel.Margin = new System.Windows.Forms.Padding(24);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(410, 414);
            this.authPanel.TabIndex = 6;
            this.authPanel.TabStop = false;
            this.authPanel.Text = "派票紀錄";
            //
            // scanButton
            //
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.scanButton.Location = new System.Drawing.Point(15, 369);
            this.scanButton.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(380, 36);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "驗證";
            this.scanButton.UseVisualStyleBackColor = true;
            //
            // scanHintButton
            //
            this.scanHintButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanHintButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.scanHintButton.Location = new System.Drawing.Point(15, 339);
            this.scanHintButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scanHintButton.Name = "scanHintButton";
            this.scanHintButton.Size = new System.Drawing.Size(380, 24);
            this.scanHintButton.TabIndex = 1;
            this.scanHintButton.Text = "將學生證放在讀卡機上，再按下 [驗證]。";
            this.scanHintButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // recordLayout
            //
            this.recordLayout.Location = new System.Drawing.Point(18, 22);
            this.recordLayout.Name = "recordLayout";
            this.recordLayout.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.recordLayout.Size = new System.Drawing.Size(377, 314);
            this.recordLayout.TabIndex = 2;
            //
            // recordEntry
            //
            this.recordEntry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recordEntry.Controls.Add(this.label2);
            this.recordEntry.Controls.Add(this.recordStudentIdLabel);
            this.recordEntry.Location = new System.Drawing.Point(18, 22);
            this.recordEntry.Name = "recordEntry";
            this.recordEntry.Size = new System.Drawing.Size(377, 36);
            this.recordEntry.TabIndex = 0;
            //
            // recordStudentIdLabel
            //
            this.recordStudentIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.recordStudentIdLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.recordStudentIdLabel.Location = new System.Drawing.Point(3, 3);
            this.recordStudentIdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.recordStudentIdLabel.Name = "recordStudentIdLabel";
            this.recordStudentIdLabel.Size = new System.Drawing.Size(169, 30);
            this.recordStudentIdLabel.TabIndex = 0;
            this.recordStudentIdLabel.Text = "B03209020";
            this.recordStudentIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // recordStatusLabel
            //
            this.recordStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordStatusLabel.Location = new System.Drawing.Point(178, 3);
            this.recordStatusLabel.Margin = new System.Windows.Forms.Padding(3);
            this.recordStatusLabel.Name = "recordStatusLabel";
            this.recordStatusLabel.Size = new System.Drawing.Size(196, 30);
            this.recordStatusLabel.TabIndex = 1;
            this.recordStatusLabel.Text = "1 號平板";
            this.recordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.authPanel);
            this.Controls.Add(this.boothLayout);
            this.Controls.Add(this.networkStatusLabel);
            this.Controls.Add(this.electionStatusLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTUVote 選務系統";
            this.boothLayout.ResumeLayout(false);
            this.examplePanel1.ResumeLayout(false);
            this.examplePanel2.ResumeLayout(false);
            this.examplePanel3.ResumeLayout(false);
            this.examplePanel4.ResumeLayout(false);
            this.authPanel.ResumeLayout(false);
            this.recordEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label electionStatusLabel;
        private System.Windows.Forms.Label networkStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel boothLayout;
        private System.Windows.Forms.Panel examplePanel1;
        private System.Windows.Forms.Label boothStatLabel1;
        private System.Windows.Forms.Label boothNumberlabel1;
        private System.Windows.Forms.Panel examplePanel2;
        private System.Windows.Forms.Label boothStatLabel2;
        private System.Windows.Forms.Label boothNumberLabel2;
        private System.Windows.Forms.Panel examplePanel3;
        private System.Windows.Forms.Label boothStatLabel3;
        private System.Windows.Forms.Label boothNumberLabel3;
        private System.Windows.Forms.Panel examplePanel4;
        private System.Windows.Forms.Label boothNumberLabel4;
        private System.Windows.Forms.Label boothStatLabel4;
        private System.Windows.Forms.Label boothTimerLabel;
        private System.Windows.Forms.GroupBox authPanel;
        private System.Windows.Forms.Label scanHintButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Panel recordEntry;
        private System.Windows.Forms.Label recordStatusLabel;
        private System.Windows.Forms.Label recordStudentIdLabel;
        private System.Windows.Forms.FlowLayoutPanel recordLayout;
    }
}
