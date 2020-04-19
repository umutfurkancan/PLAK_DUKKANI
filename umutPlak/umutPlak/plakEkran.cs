using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace umutPlak
{
    public partial class plakEkran : Form
    {
        public plakEkran()
        {
            InitializeComponent();
        }

        private void btn_plak_Click(object sender, EventArgs e)
        {
            PlakKaydet Kaydet = new PlakKaydet();
            Kaydet.Show();
            this.Hide();

        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            liste list = new liste();
            list.Show();
            this.Hide();

        }

        private void plakEkran_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            txt_saat.Text = saat;
        }


    }
}
