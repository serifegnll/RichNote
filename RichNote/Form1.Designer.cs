namespace RichNote
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBul = new System.Windows.Forms.Button();
            this.btUstSimge = new System.Windows.Forms.Button();
            this.btAltSimge = new System.Windows.Forms.Button();
            this.btArkaPlanRengi = new System.Windows.Forms.Button();
            this.btYaziRengi = new System.Windows.Forms.Button();
            this.cbFontStili = new System.Windows.Forms.ComboBox();
            this.cbFontBoyutu = new System.Windows.Forms.ComboBox();
            this.cbFontAdi = new System.Windows.Forms.ComboBox();
            this.BtnIleriAl = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.rtbYaziAlani = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBul);
            this.panel1.Controls.Add(this.btUstSimge);
            this.panel1.Controls.Add(this.btAltSimge);
            this.panel1.Controls.Add(this.btArkaPlanRengi);
            this.panel1.Controls.Add(this.btYaziRengi);
            this.panel1.Controls.Add(this.cbFontStili);
            this.panel1.Controls.Add(this.cbFontBoyutu);
            this.panel1.Controls.Add(this.cbFontAdi);
            this.panel1.Controls.Add(this.BtnIleriAl);
            this.panel1.Controls.Add(this.btnGeriAl);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnAc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 66);
            this.panel1.TabIndex = 0;
            // 
            // btBul
            // 
            this.btBul.Location = new System.Drawing.Point(671, 12);
            this.btBul.Name = "btBul";
            this.btBul.Size = new System.Drawing.Size(75, 23);
            this.btBul.TabIndex = 11;
            this.btBul.Text = "Bul";
            this.btBul.UseVisualStyleBackColor = true;
            this.btBul.Click += new System.EventHandler(this.btBul_Click);
            // 
            // btUstSimge
            // 
            this.btUstSimge.Image = global::RichNote.Properties.Resources.üst_simge;
            this.btUstSimge.Location = new System.Drawing.Point(642, 12);
            this.btUstSimge.Name = "btUstSimge";
            this.btUstSimge.Size = new System.Drawing.Size(23, 23);
            this.btUstSimge.TabIndex = 10;
            this.btUstSimge.UseVisualStyleBackColor = true;
            this.btUstSimge.Click += new System.EventHandler(this.btUstSimge_Click);
            // 
            // btAltSimge
            // 
            this.btAltSimge.Image = global::RichNote.Properties.Resources.alt_simge;
            this.btAltSimge.Location = new System.Drawing.Point(610, 12);
            this.btAltSimge.Name = "btAltSimge";
            this.btAltSimge.Size = new System.Drawing.Size(26, 23);
            this.btAltSimge.TabIndex = 9;
            this.btAltSimge.UseVisualStyleBackColor = true;
            this.btAltSimge.Click += new System.EventHandler(this.btAltSimge_Click);
            // 
            // btArkaPlanRengi
            // 
            this.btArkaPlanRengi.Location = new System.Drawing.Point(566, 11);
            this.btArkaPlanRengi.Name = "btArkaPlanRengi";
            this.btArkaPlanRengi.Size = new System.Drawing.Size(27, 23);
            this.btArkaPlanRengi.TabIndex = 8;
            this.btArkaPlanRengi.Text = "A";
            this.btArkaPlanRengi.UseVisualStyleBackColor = true;
            this.btArkaPlanRengi.Click += new System.EventHandler(this.btArkaPlanRengi_Click);
            // 
            // btYaziRengi
            // 
            this.btYaziRengi.Location = new System.Drawing.Point(533, 11);
            this.btYaziRengi.Name = "btYaziRengi";
            this.btYaziRengi.Size = new System.Drawing.Size(27, 23);
            this.btYaziRengi.TabIndex = 7;
            this.btYaziRengi.Text = "A";
            this.btYaziRengi.UseVisualStyleBackColor = true;
            this.btYaziRengi.Click += new System.EventHandler(this.btYaziRengi_Click);
            // 
            // cbFontStili
            // 
            this.cbFontStili.FormattingEnabled = true;
            this.cbFontStili.Location = new System.Drawing.Point(394, 11);
            this.cbFontStili.Name = "cbFontStili";
            this.cbFontStili.Size = new System.Drawing.Size(121, 24);
            this.cbFontStili.TabIndex = 6;
            this.cbFontStili.SelectedIndexChanged += new System.EventHandler(this.cbFontStili_SelectedIndexChanged);
            // 
            // cbFontBoyutu
            // 
            this.cbFontBoyutu.FormattingEnabled = true;
            this.cbFontBoyutu.Location = new System.Drawing.Point(267, 11);
            this.cbFontBoyutu.Name = "cbFontBoyutu";
            this.cbFontBoyutu.Size = new System.Drawing.Size(121, 24);
            this.cbFontBoyutu.TabIndex = 5;
            this.cbFontBoyutu.SelectedIndexChanged += new System.EventHandler(this.cbFontBoyutu_SelectedIndexChanged);
            // 
            // cbFontAdi
            // 
            this.cbFontAdi.FormattingEnabled = true;
            this.cbFontAdi.Location = new System.Drawing.Point(140, 11);
            this.cbFontAdi.Name = "cbFontAdi";
            this.cbFontAdi.Size = new System.Drawing.Size(121, 24);
            this.cbFontAdi.TabIndex = 4;
            this.cbFontAdi.SelectedIndexChanged += new System.EventHandler(this.cbFontAdi_SelectedIndexChanged);
            // 
            // BtnIleriAl
            // 
            this.BtnIleriAl.Image = global::RichNote.Properties.Resources.İleri;
            this.BtnIleriAl.Location = new System.Drawing.Point(109, 11);
            this.BtnIleriAl.Name = "BtnIleriAl";
            this.BtnIleriAl.Size = new System.Drawing.Size(25, 24);
            this.BtnIleriAl.TabIndex = 3;
            this.BtnIleriAl.UseVisualStyleBackColor = true;
            this.BtnIleriAl.Click += new System.EventHandler(this.BtnIleriAl_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Image = global::RichNote.Properties.Resources.Geri;
            this.btnGeriAl.Location = new System.Drawing.Point(77, 11);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(26, 24);
            this.btnGeriAl.TabIndex = 2;
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::RichNote.Properties.Resources.kaydet;
            this.btnKaydet.Location = new System.Drawing.Point(45, 11);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(26, 24);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAc
            // 
            this.btnAc.Image = global::RichNote.Properties.Resources.DosyaAç;
            this.btnAc.Location = new System.Drawing.Point(12, 11);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(27, 24);
            this.btnAc.TabIndex = 0;
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // rtbYaziAlani
            // 
            this.rtbYaziAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbYaziAlani.Location = new System.Drawing.Point(0, 66);
            this.rtbYaziAlani.Name = "rtbYaziAlani";
            this.rtbYaziAlani.Size = new System.Drawing.Size(758, 453);
            this.rtbYaziAlani.TabIndex = 1;
            this.rtbYaziAlani.Text = "";
            this.rtbYaziAlani.SelectionChanged += new System.EventHandler(this.rtbYaziAlani_SelectionChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 519);
            this.Controls.Add(this.rtbYaziAlani);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBul;
        private System.Windows.Forms.Button btUstSimge;
        private System.Windows.Forms.Button btAltSimge;
        private System.Windows.Forms.Button btArkaPlanRengi;
        private System.Windows.Forms.Button btYaziRengi;
        private System.Windows.Forms.ComboBox cbFontStili;
        private System.Windows.Forms.ComboBox cbFontBoyutu;
        private System.Windows.Forms.ComboBox cbFontAdi;
        private System.Windows.Forms.Button BtnIleriAl;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.RichTextBox rtbYaziAlani;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

