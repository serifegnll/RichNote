using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RichNote
{
    public partial class Form1 : Form
    {
        public bool kapat; //
        void FontAraclariniAyarla()
        {            
            //************ Sistemdeki font isimlerini alır ve cbFontAdi na ekler ***************
         
                // sistemdeki font isimlerini tutacak dizi değişkeni
                    FontFamily[] fontFamilies;

                // yüklü fontları alan kolleksiyon
                    InstalledFontCollection installedFontCollection = new InstalledFontCollection();

                // kolleksiyondan font isimlerini diziye alıyoruz
                    fontFamilies = installedFontCollection.Families;


                    int count = fontFamilies.Length; // yüklü font sayısı

                // font sayısı comboboxa ekleniyor
                    for (int j=0;j<count;++j)
                    {
                        cbFontAdi.Items.Add(fontFamilies[j].Name);
                    }

            //*********************Font büyüklüklerini cbFontBoyutu na yükler******************
                for (int i = 6; i < 27; i++)
                {
                    cbFontBoyutu.Items.Add(i);
                }

            //*******************Font stilini cbFontStili ne yükler ****************************

                cbFontStili.Items.Add(FontStyle.Bold);
                cbFontStili.Items.Add(FontStyle.Italic);
                cbFontStili.Items.Add(FontStyle.Regular);
                cbFontStili.Items.Add(FontStyle.Underline);
                cbFontStili.Items.Add(FontStyle.Strikeout);

        }

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                FontAraclariniAyarla();
            rtbYaziAlani.SelectionProtected = false;
            rtbYaziAlani.HideSelection = false;
            kapat = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydet butonu
            saveFileDialog1.Filter = "Zengin Metin |*.rtf"; 
            saveFileDialog1.DefaultExt = "rtf"; // Belge türü
            DialogResult cevap = saveFileDialog1.ShowDialog(); //Kaydetme penceresinde basılan tuş

            if( cevap!= DialogResult.Cancel) //eğer iptal tuşuna basılmamışsa dosyayı kaydederiz
            {
                rtbYaziAlani.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Dosya Kaydedildi!");
            }


        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            //kayıtlı dosyayı açma işlemleri
            openFileDialog1.Filter = "Zengin Metin |*.rtf | Normal Text|*.txt";
            openFileDialog1.DefaultExt = "rtf";
            DialogResult cevap = openFileDialog1.ShowDialog();

            if(cevap!=DialogResult.Cancel)
            {
                
                StreamReader okuyucu = new StreamReader(openFileDialog1.FileName);
                rtbYaziAlani.Rtf = okuyucu.ReadToEnd();
                okuyucu.Close();
            }

        }

        private void cbFontAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font mevcutFont = rtbYaziAlani.SelectionFont;
            if (mevcutFont == null) return;
            Font yeniFont = new Font(cbFontAdi.Text, mevcutFont.Size,mevcutFont.Style);
            rtbYaziAlani.SelectionFont = yeniFont;         
            
        }

        private void cbFontBoyutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font mevcutFont = rtbYaziAlani.SelectionFont;
            if (mevcutFont == null) return;
            Font yeniFont = new Font(mevcutFont.FontFamily, float.Parse(cbFontBoyutu.Text),mevcutFont.Style);
            rtbYaziAlani.SelectionFont = yeniFont;
        }

        private void cbFontStili_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font mevcutFont = rtbYaziAlani.SelectionFont;
            if (mevcutFont == null) return;
            Font yeniFont = new Font(mevcutFont.FontFamily,mevcutFont.Size,(FontStyle)cbFontStili.SelectedItem);
            rtbYaziAlani.SelectionFont = yeniFont;
        }

        private void rtbYaziAlani_SelectionChanged(object sender, EventArgs e)
        {
            Font mevcutFont = rtbYaziAlani.SelectionFont;
            cbFontAdi.Text = mevcutFont.Name;
            cbFontBoyutu.Text = ((int)mevcutFont.Size).ToString();
            cbFontStili.Text = mevcutFont.Style.ToString();
            btYaziRengi.ForeColor = rtbYaziAlani.SelectionColor;
            btArkaPlanRengi.BackColor = rtbYaziAlani.SelectionColor;
        }

        private void btYaziRengi_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            DialogResult cevap = colorDialog1.ShowDialog();
            if(cevap!= DialogResult.Cancel)
            {
                btYaziRengi.ForeColor = colorDialog1.Color;
                rtbYaziAlani.SelectionColor = colorDialog1.Color;
            }
        }

        private void btArkaPlanRengi_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            DialogResult cevap = colorDialog1.ShowDialog();
            if (cevap != DialogResult.Cancel)
            {
                btArkaPlanRengi.BackColor = colorDialog1.Color;
                rtbYaziAlani.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            rtbYaziAlani.Undo();
        }

        private void BtnIleriAl_Click(object sender, EventArgs e)
        {
            rtbYaziAlani.Redo();
        }

        private void btAltSimge_Click(object sender, EventArgs e)
        {
            rtbYaziAlani.SelectionCharOffset = -3;
            
        }

        private void btUstSimge_Click(object sender, EventArgs e)
        {
            rtbYaziAlani.SelectionCharOffset = 3;
        }

        private void btBul_Click(object sender, EventArgs e)
        {
            FrmBul BulFormu = new FrmBul();
            BulFormu.RichYazi = rtbYaziAlani;
            BulFormu.Show();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kapat frmKapat = new Kapat();            
            frmKapat.AnaForm = this;
            frmKapat.ShowDialog();
            if (!kapat) e.Cancel = true;
            
            /*
           DialogResult cevap= MessageBox.Show("Emin misin?","Kapat",MessageBoxButtons.YesNo);
            if(cevap==DialogResult.No)
            {
                e.Cancel = true;
            }*/
        }
    }
}
