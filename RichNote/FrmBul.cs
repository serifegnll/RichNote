using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichNote
{
    public partial class FrmBul : Form
    {
        public RichTextBox RichYazi { get; set; }
        int aramaBaslangici = 0;
        public FrmBul()
        {
            InitializeComponent();
        }

        private void FrmBul_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            aramaBaslangici = 0;
            this.TopMost = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBul_Click(object sender, EventArgs e)
        {
            RichTextBoxFinds AramaSekli = (cbHarfDuyarli.Checked) ? RichTextBoxFinds.MatchCase: RichTextBoxFinds.None; 
            
            int yer = RichYazi.Find(txtAranan.Text,aramaBaslangici, AramaSekli);
            aramaBaslangici = RichYazi.SelectionStart + 1;
            if(yer<0)
            {
                MessageBox.Show("Arama tamamlandı.");
                aramaBaslangici = 0;
            }
            
                         
            
        }
    }
}
