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
    public partial class Kapat : Form
    {
        public Form1 AnaForm { get; set; }
        public Kapat()
        {
            InitializeComponent();
        }

        private void btHayir_Click(object sender, EventArgs e)
        {
            AnaForm.kapat = false;
            this.Close();

        }

        private void btEvet_Click(object sender, EventArgs e)
        {
            AnaForm.kapat = true;
            this.Close();
        }
    }
}
