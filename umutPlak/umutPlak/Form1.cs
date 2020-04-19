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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            string id = txt_id.Text;
            string sifre = txt_sifre.Text;
            
                baglantilar giris = new baglantilar();
            giris.girisYap(id,sifre,this);
            

          
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            kayitol kayit = new kayitol();
            kayit.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
