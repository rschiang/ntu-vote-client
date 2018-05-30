namespace NTUOSC.Vote
{
    partial class RecordPanel
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
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // studentIdLabel
            //
            this.studentIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentIdLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.studentIdLabel.Location = new System.Drawing.Point(3, 3);
            this.studentIdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(169, 30);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "---------";
            this.studentIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // statusLabel
            //
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(178, 3);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(3);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(196, 30);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "授權中";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // RecordPanel
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.statusLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Name = "RecordPanel";
            this.Size = new System.Drawing.Size(377, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label studentIdLabel;
    }
}
