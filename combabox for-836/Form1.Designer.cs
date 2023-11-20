namespace combabox_for_836
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
            this.btnAktar = new System.Windows.Forms.Button();
            this.cmbCift = new System.Windows.Forms.ComboBox();
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.cmbTek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTekAtar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.Red;
            this.btnAktar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAktar.Location = new System.Drawing.Point(12, 269);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(164, 60);
            this.btnAktar.TabIndex = 0;
            this.btnAktar.Text = "Çift sayı aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // cmbCift
            // 
            this.cmbCift.FormattingEnabled = true;
            this.cmbCift.Location = new System.Drawing.Point(12, 359);
            this.cmbCift.Name = "cmbCift";
            this.cmbCift.Size = new System.Drawing.Size(164, 21);
            this.cmbCift.TabIndex = 1;
            // 
            // lbSayi
            // 
            this.lbSayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.Location = new System.Drawing.Point(12, 12);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(164, 251);
            this.lbSayi.TabIndex = 2;
            // 
            // cmbTek
            // 
            this.cmbTek.FormattingEnabled = true;
            this.cmbTek.Location = new System.Drawing.Point(198, 359);
            this.cmbTek.Name = "cmbTek";
            this.cmbTek.Size = new System.Drawing.Size(164, 21);
            this.cmbTek.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Çift satı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tek sayı";
            // 
            // btnTekAtar
            // 
            this.btnTekAtar.BackColor = System.Drawing.Color.Red;
            this.btnTekAtar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTekAtar.Location = new System.Drawing.Point(198, 269);
            this.btnTekAtar.Name = "btnTekAtar";
            this.btnTekAtar.Size = new System.Drawing.Size(164, 60);
            this.btnTekAtar.TabIndex = 6;
            this.btnTekAtar.Text = "Tek sayı aktar";
            this.btnTekAtar.UseVisualStyleBackColor = false;
            this.btnTekAtar.Click += new System.EventHandler(this.btnTekAtar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(420, 469);
            this.Controls.Add(this.btnTekAtar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTek);
            this.Controls.Add(this.lbSayi);
            this.Controls.Add(this.cmbCift);
            this.Controls.Add(this.btnAktar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ComboBox cmbCift;
        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.ComboBox cmbTek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTekAtar;
    }
}

