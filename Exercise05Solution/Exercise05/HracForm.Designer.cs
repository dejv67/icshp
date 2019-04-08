namespace Exercise05
{
    partial class HracForm
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
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxGol = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelKlub = new System.Windows.Forms.Label();
            this.labelGoly = new System.Windows.Forms.Label();
            this.comboBoxKlub = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(178, 34);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(125, 20);
            this.textBoxJmeno.TabIndex = 0;
            this.textBoxJmeno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGol
            // 
            this.textBoxGol.Location = new System.Drawing.Point(178, 134);
            this.textBoxGol.Name = "textBoxGol";
            this.textBoxGol.Size = new System.Drawing.Size(125, 20);
            this.textBoxGol.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(53, 171);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(203, 171);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 23);
            this.btnStorno.TabIndex = 4;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(50, 41);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(38, 13);
            this.labelJmeno.TabIndex = 5;
            this.labelJmeno.Text = "Jméno";
            this.labelJmeno.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelKlub
            // 
            this.labelKlub.AutoSize = true;
            this.labelKlub.Location = new System.Drawing.Point(53, 90);
            this.labelKlub.Name = "labelKlub";
            this.labelKlub.Size = new System.Drawing.Size(28, 13);
            this.labelKlub.TabIndex = 6;
            this.labelKlub.Text = "Klub";
            // 
            // labelGoly
            // 
            this.labelGoly.AutoSize = true;
            this.labelGoly.Location = new System.Drawing.Point(53, 141);
            this.labelGoly.Name = "labelGoly";
            this.labelGoly.Size = new System.Drawing.Size(28, 13);
            this.labelGoly.TabIndex = 7;
            this.labelGoly.Text = "Góly";
            // 
            // comboBoxKlub
            // 
            this.comboBoxKlub.FormattingEnabled = true;
            this.comboBoxKlub.Location = new System.Drawing.Point(178, 81);
            this.comboBoxKlub.Name = "comboBoxKlub";
            this.comboBoxKlub.Size = new System.Drawing.Size(125, 21);
            this.comboBoxKlub.TabIndex = 8;
            // 
            // HracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 206);
            this.Controls.Add(this.comboBoxKlub);
            this.Controls.Add(this.labelGoly);
            this.Controls.Add(this.labelKlub);
            this.Controls.Add(this.labelJmeno);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBoxGol);
            this.Controls.Add(this.textBoxJmeno);
            this.Name = "HracForm";
            this.Text = "Hráč";
            this.Load += new System.EventHandler(this.HracForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxGol;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelKlub;
        private System.Windows.Forms.Label labelGoly;
        private System.Windows.Forms.ComboBox comboBoxKlub;
    }
}

