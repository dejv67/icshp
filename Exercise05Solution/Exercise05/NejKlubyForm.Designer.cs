namespace Exercise05
{
    partial class NejKlubyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPocGolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKluby = new System.Windows.Forms.TextBox();
            this.btnNejOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet gólů:";
            // 
            // textBoxPocGolu
            // 
            this.textBoxPocGolu.Location = new System.Drawing.Point(16, 43);
            this.textBoxPocGolu.Name = "textBoxPocGolu";
            this.textBoxPocGolu.Size = new System.Drawing.Size(100, 20);
            this.textBoxPocGolu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kluby";
            // 
            // textBoxKluby
            // 
            this.textBoxKluby.Location = new System.Drawing.Point(19, 112);
            this.textBoxKluby.Multiline = true;
            this.textBoxKluby.Name = "textBoxKluby";
            this.textBoxKluby.Size = new System.Drawing.Size(358, 114);
            this.textBoxKluby.TabIndex = 3;
            // 
            // btnNejOk
            // 
            this.btnNejOk.Location = new System.Drawing.Point(302, 253);
            this.btnNejOk.Name = "btnNejOk";
            this.btnNejOk.Size = new System.Drawing.Size(75, 23);
            this.btnNejOk.TabIndex = 4;
            this.btnNejOk.Text = "OK";
            this.btnNejOk.UseVisualStyleBackColor = true;
            this.btnNejOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // NejKlubyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 288);
            this.Controls.Add(this.btnNejOk);
            this.Controls.Add(this.textBoxKluby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPocGolu);
            this.Controls.Add(this.label1);
            this.Name = "NejKlubyForm";
            this.Text = "Nejlepší Kluby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPocGolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKluby;
        private System.Windows.Forms.Button btnNejOk;
    }
}