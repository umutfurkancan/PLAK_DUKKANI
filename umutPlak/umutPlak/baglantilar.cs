using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace umutPlak
{
    class baglantilar
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UDQUKC4\SQLEXPRESS;Initial Catalog=umutPlak;User ID=sa;Password=1221");
        SqlCommand command;
        SqlDataReader reader;
        public void girisYap(string id, string sifre, Form1 frm1)
        {
            command = new SqlCommand("SELECT * FROM kullanici where kullanici_ID='" + id + "' AND kullanici_sifre='" + sifre + "' ", conn);
            conn.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. Yönlendiriliyorsunuz...");
                plakEkran ekrn = new plakEkran();
                ekrn.Show();

                frm1.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            conn.Close();
            conn.Dispose();


        }
        public void kayitOl(string AdSoyad, string k_id, string sifre)
        {
            
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {

                SqlCommand komut = new SqlCommand("insert into kullanici (kullanici_adiSoyadi,kullanici_ID,kullanici_sifre) values ('" + AdSoyad.ToString() + "','" + k_id.ToString() + "','" + sifre.ToString() + "')", conn);
                
                    komut.ExecuteNonQuery();
             
                conn.Close();

                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");

            }
        }
        public void plakakayit(string plak_adi, string plak_cins, string plak_tarih, string plak_sanatci, string plak_turu, string plak_fiyat)
        {
            conn.Open();
           
            if (conn.State == System.Data.ConnectionState.Open)
            {

                SqlCommand komut = new SqlCommand("insert into plak (plak_adi,plak_cinsi,plak_tarih,plak_sanatci,plak_turu,plak_fiyat) values ('" + plak_adi.ToString() + "','" + plak_cins.ToString() + "','" + plak_tarih.ToString() + "','" + plak_sanatci.ToString() + "','" + plak_turu.ToString() + "','" + plak_fiyat.ToString() + "')", conn);

                komut.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Kayıt yapıldı güncelleniyor.");

            }

        }
    }
}
