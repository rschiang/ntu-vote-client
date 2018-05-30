namespace NTUOSC.Vote
{
    partial class BoothPanel
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // numberLabel
            //
            this.numberLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.numberLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numberLabel.Location = new System.Drawing.Point(3, 3);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(174, 18);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "0";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // statLabel
            //
            this.statLabel.Location = new System.Drawing.Point(3, 159);
            this.statLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(174, 18);
            this.statLabel.TabIndex = 1;
            this.statLabel.Text = "離線";
            this.statLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // timerLabel
            //
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.Font = new System.Drawing.Font("微軟正黑體", 42F);
            this.timerLabel.Location = new System.Drawing.Point(3, 21);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(174, 138);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // BoothPanel
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.numberLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Name = "BoothPanel";
            this.Size = new System.Drawing.Size(180, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label timerLabel;
    }
}
