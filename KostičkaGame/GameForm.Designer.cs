using System.ComponentModel;

namespace KostičkaGame {
    partial class GameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.PlayingPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.ForeColor = System.Drawing.Color.Coral;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 58);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score";
            // 
            // LivesLabel
            // 
            this.LivesLabel.ForeColor = System.Drawing.Color.Coral;
            this.LivesLabel.Location = new System.Drawing.Point(12, 21);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(100, 23);
            this.LivesLabel.TabIndex = 1;
            this.LivesLabel.Text = "život";
            // 
            // PlayingPanel
            // 
            this.PlayingPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (251)))), ((int) (((byte) (222)))), ((int) (((byte) (68)))));
            this.PlayingPanel.Location = new System.Drawing.Point(12, 84);
            this.PlayingPanel.Name = "PlayingPanel";
            this.PlayingPanel.Size = new System.Drawing.Size(400, 400);
            this.PlayingPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (51)))), ((int) (((byte) (74)))));
            this.ClientSize = new System.Drawing.Size(428, 499);
            this.Controls.Add(this.PlayingPanel);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Panel PlayingPanel;

        #endregion
    }
}