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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.electionStatusLabel = new System.Windows.Forms.Label();
            this.networkStatusLabel = new System.Windows.Forms.Label();
            this.boothLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.authPanel = new System.Windows.Forms.GroupBox();
            this.recordLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.scanHintButton = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.authPanel.SuspendLayout();
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
            this.boothLayout.Location = new System.Drawing.Point(39, 120);
            this.boothLayout.Margin = new System.Windows.Forms.Padding(24);
            this.boothLayout.Name = "boothLayout";
            this.boothLayout.Size = new System.Drawing.Size(372, 414);
            this.boothLayout.TabIndex = 5;
            // 
            // authPanel
            // 
            this.authPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // recordLayout
            // 
            this.recordLayout.Location = new System.Drawing.Point(18, 22);
            this.recordLayout.Name = "recordLayout";
            this.recordLayout.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.recordLayout.Size = new System.Drawing.Size(377, 314);
            this.recordLayout.TabIndex = 2;
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
            // pingTimer
            // 
            this.pingTimer.Enabled = true;
            this.pingTimer.Interval = 1000;
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
            this.authPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label electionStatusLabel;
        private System.Windows.Forms.Label networkStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel boothLayout;
        private System.Windows.Forms.GroupBox authPanel;
        private System.Windows.Forms.Label scanHintButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.FlowLayoutPanel recordLayout;
        private System.Windows.Forms.Timer pingTimer;
    }
}
