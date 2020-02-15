namespace KruskalAlgoritmasi
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
            this.grbButonlar = new System.Windows.Forms.GroupBox();
            this.lstIstatistik = new System.Windows.Forms.ListBox();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.nmKumeSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnRastgeleNokta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbToplar = new System.Windows.Forms.GroupBox();
            this.grbButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKumeSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // grbButonlar
            // 
            this.grbButonlar.Controls.Add(this.lstIstatistik);
            this.grbButonlar.Controls.Add(this.btnHepsiniSil);
            this.grbButonlar.Controls.Add(this.btnCalistir);
            this.grbButonlar.Controls.Add(this.nmKumeSayisi);
            this.grbButonlar.Controls.Add(this.btnRastgeleNokta);
            this.grbButonlar.Controls.Add(this.label2);
            this.grbButonlar.Controls.Add(this.label1);
            this.grbButonlar.Controls.Add(this.textBox1);
            this.grbButonlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbButonlar.Location = new System.Drawing.Point(0, 0);
            this.grbButonlar.Name = "grbButonlar";
            this.grbButonlar.Size = new System.Drawing.Size(174, 368);
            this.grbButonlar.TabIndex = 0;
            this.grbButonlar.TabStop = false;
            this.grbButonlar.Text = "Butonlar";
            // 
            // lstIstatistik
            // 
            this.lstIstatistik.FormattingEnabled = true;
            this.lstIstatistik.HorizontalScrollbar = true;
            this.lstIstatistik.Location = new System.Drawing.Point(6, 209);
            this.lstIstatistik.Name = "lstIstatistik";
            this.lstIstatistik.Size = new System.Drawing.Size(153, 147);
            this.lstIstatistik.TabIndex = 9;
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(15, 74);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(125, 23);
            this.btnHepsiniSil.TabIndex = 8;
            this.btnHepsiniSil.Text = "HepsiniSil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(12, 150);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(144, 45);
            this.btnCalistir.TabIndex = 6;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // nmKumeSayisi
            // 
            this.nmKumeSayisi.Location = new System.Drawing.Point(93, 113);
            this.nmKumeSayisi.Name = "nmKumeSayisi";
            this.nmKumeSayisi.Size = new System.Drawing.Size(66, 20);
            this.nmKumeSayisi.TabIndex = 5;
            // 
            // btnRastgeleNokta
            // 
            this.btnRastgeleNokta.Location = new System.Drawing.Point(15, 45);
            this.btnRastgeleNokta.Name = "btnRastgeleNokta";
            this.btnRastgeleNokta.Size = new System.Drawing.Size(125, 23);
            this.btnRastgeleNokta.TabIndex = 4;
            this.btnRastgeleNokta.Text = "Rastgele Nokta Ekle";
            this.btnRastgeleNokta.UseVisualStyleBackColor = true;
            this.btnRastgeleNokta.Click += new System.EventHandler(this.btnRastgeleNokta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Küme Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // grbToplar
            // 
            this.grbToplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbToplar.Location = new System.Drawing.Point(174, 0);
            this.grbToplar.Name = "grbToplar";
            this.grbToplar.Size = new System.Drawing.Size(571, 368);
            this.grbToplar.TabIndex = 1;
            this.grbToplar.TabStop = false;
            this.grbToplar.Text = "Toplar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 368);
            this.Controls.Add(this.grbToplar);
            this.Controls.Add(this.grbButonlar);
            this.Name = "Form1";
            this.Text = "Kruskal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbButonlar.ResumeLayout(false);
            this.grbButonlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKumeSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbButonlar;
        private System.Windows.Forms.Button btnRastgeleNokta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.NumericUpDown nmKumeSayisi;
        private System.Windows.Forms.GroupBox grbToplar;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.ListBox lstIstatistik;
    }
}

