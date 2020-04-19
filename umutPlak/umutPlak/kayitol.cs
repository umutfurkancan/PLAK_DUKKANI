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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string AdSoyad = txt_adsoyad.Text;
            string k_id = txt_kID.Text;
            string sifre = txt_sifre.Text;
        
            baglantilar kayit = new baglantilar();
            kayit.kayitOl(AdSoyad, k_id, sifre);
        }

        private void kayitol_Load(object sender, EventArgs e)
        {
            
        }
    }
}
