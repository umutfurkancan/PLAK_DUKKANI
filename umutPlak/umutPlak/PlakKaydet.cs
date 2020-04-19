using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace umutPlak
{
    public partial class PlakKaydet : Form
    {
        SqlCommand komut;
        public PlakKaydet()
        {
            InitializeComponent();
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            plakEkran plak = new plakEkran();
            plak.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UDQUKC4\SQLEXPRESS;Initial Catalog=umutPlak;User ID=sa;Password=1221");
     
        private void plakgetir()
        {
            
            SqlDataAdapter cod = new SqlDataAdapter("select * from plak ",conn);
            DataSet ds = new DataSet();
            cod.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string plak_adi = txt_adi.Text;
            string plak_cins = txt_cinsi.Text;
            string plak_tarih = txt_tarih.Text;
            string plak_sanatci = txt_sanatci.Text;
            string plak_turu = txt_turu.Text;
            string plak_fiyat = txt_fiyat.Text;
            baglantilar plakkayit = new baglantilar();
            plakkayit.plakakayit(plak_adi, plak_cins, plak_tarih, plak_sanatci, plak_turu, plak_fiyat);
            plakgetir();
            conn.Close();
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
           plakgetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilmis = dataGridView1.SelectedCells[0].RowIndex;
            string plak_adi = dataGridView1.Rows[secilmis].Cells[1].Value.ToString();
            string plak_cins = dataGridView1.Rows[secilmis].Cells[2].Value.ToString();
            string plak_tarih = dataGridView1.Rows[secilmis].Cells[3].Value.ToString();
            string sanatci = dataGridView1.Rows[secilmis].Cells[4].Value.ToString();
            string turu= dataGridView1.Rows[secilmis].Cells[5].Value.ToString();
            string fiyat= dataGridView1.Rows[secilmis].Cells[6].Value.ToString();
            txt_adi.Text = plak_adi;
            txt_cinsi.Text = plak_cins;
            txt_tarih.Text = plak_tarih;
            txt_sanatci.Text = sanatci;
            txt_turu.Text = turu;
            txt_fiyat.Text = fiyat;
        }

        private void btn_veriGuncel_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = "UPDATE plak SET plak_fiyat=@plak_fiyat WHERE plak_adi=@plak_adi";
            komut = new SqlCommand(sorgu, conn);
           
            komut.Parameters.AddWithValue("@plak_adi", txt_adi.Text);
            komut.Parameters.AddWithValue("@plak_fiyat", Convert.ToInt16(txt_fiyat.Text));

      
            komut.ExecuteNonQuery();
            conn.Close();
            plakgetir();
        }

  

        private void PlakKaydet_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            txt_saat.Text = saat;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from plak where plak_adi=@adi", conn);
            komut.Parameters.AddWithValue("@adi", txt_ara.Text);
            komut.ExecuteNonQuery();
            plakgetir();
            conn.Close();

        }
    }
}
