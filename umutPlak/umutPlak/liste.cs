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
    public partial class liste : Form
    {
        public liste()
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
        private void liste_Load(object sender, EventArgs e)
        {
            plakgetir();
            timer1.Enabled = true;

        }
        private void plakgetir()
        {
            
            SqlDataAdapter cod = new SqlDataAdapter("select * from plak ", conn);
            DataSet ds = new DataSet();
            cod.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from plak where plak_adi=@adi",conn);
            komut.Parameters.AddWithValue("@adi", txt_ara.Text);
            komut.ExecuteNonQuery();
            plakgetir();
            conn.Close();

        }
        
        
        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = txt_ara.Text;
            cumle = "Select * from plak where plak_adi like '%" + txt_ara.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            txt_saat.Text = saat;
        }
    }
}
