﻿namespace Hra
{
    partial class Form1
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
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accurancyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.diffucultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 55;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(738, 105);
            this.gameListBox.TabIndex = 0;
            this.gameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameListBox_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.accurancyLabel,
            this.difficultyLabel,
            this.diffucultProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 83);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(52, 17);
            this.correctLabel.Text = "Correct: ";
            this.correctLabel.Click += new System.EventHandler(this.correctLabel_Click);
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(50, 17);
            this.missedLabel.Text = "Missed: ";
            // 
            // accurancyLabel
            // 
            this.accurancyLabel.Name = "accurancyLabel";
            this.accurancyLabel.Size = new System.Drawing.Size(66, 17);
            this.accurancyLabel.Text = "Accurancy:";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(453, 17);
            this.difficultyLabel.Spring = true;
            this.difficultyLabel.Text = "Difficult";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.difficultyLabel.Click += new System.EventHandler(this.difficultyLabel_Click);
            // 
            // diffucultProgressBar
            // 
            this.diffucultProgressBar.Maximum = 800;
            this.diffucultProgressBar.Name = "diffucultProgressBar";
            this.diffucultProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 800;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 105);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel accurancyLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyLabel;
        private System.Windows.Forms.ToolStripProgressBar diffucultProgressBar;
        private System.Windows.Forms.Timer Timer;
    }
}

