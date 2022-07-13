using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MağazaOtomasyonn
{
    public partial class frmÜrünEKle : Form
    {
        public frmÜrünEKle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");


        bool durum;
        private void barkodkontrol()
        {
            try { 
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (TxtBarkodNo.Text==read["barkodno"].ToString() || TxtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("kontrol sql hatası");
            }
            catch (Exception ex)
            {
                MessageBox.Show("kontrol başka bir hata!");
            }
            finally
            {
                baglanti.Close();
            }
            
        }

        private void frmÜrünEKle_Load(object sender, EventArgs e)
        {
            Kategorigetir();
        }
        private void Kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategori", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori_adi"].ToString());
            }
            baglanti.Close();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kategoriId = 0;
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komutKategoriId = new SqlCommand("select id from kategori where kategori_adi = '" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader readKategoriId = komutKategoriId.ExecuteReader();
            while (readKategoriId.Read())
            {
                kategoriId = Int32.Parse(readKategoriId["id"].ToString());

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from marka where kategori_id='" + kategoriId + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka_adi"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            try
            {
                barkodkontrol();
                if (durum == true)
                {
                    int markaId = 0;
                    int kategoriId = 0;
                    baglanti.Open();
                    SqlCommand komutKategoriId = new SqlCommand("select id from kategori where kategori_adi = '" + comboKategori.SelectedItem + "'", baglanti);
                    SqlDataReader readKategoriId = komutKategoriId.ExecuteReader();
                    while (readKategoriId.Read())
                    {
                        kategoriId = Int32.Parse(readKategoriId["id"].ToString());

                    }
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komutMarkaId = new SqlCommand("select id from marka where marka_adi = '" + comboMarka.SelectedItem + "'", baglanti);
                    SqlDataReader readMarkaId = komutMarkaId.ExecuteReader();
                    while (readMarkaId.Read())
                    {
                        markaId = Int32.Parse(readMarkaId["id"].ToString());

                    }
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into urun (barkod_no,kategori_id,marka_id,urun_adi,miktar,alis_fiyati,satis_fiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                    komut.Parameters.AddWithValue(("@barkodno"), TxtBarkodNo.Text);
                    komut.Parameters.AddWithValue(("@kategori"), kategoriId);
                    komut.Parameters.AddWithValue(("@marka"), markaId);
                    komut.Parameters.AddWithValue(("@urunadi"), txtÜrünAdı.Text);
                    komut.Parameters.AddWithValue(("@miktar"), int.Parse(txtMiktarı.Text));
                    komut.Parameters.AddWithValue(("@alisfiyati"), double.Parse(txtAlışFiyatı.Text));
                    komut.Parameters.AddWithValue(("@satisfiyati"), double.Parse(txtSatışFiyatı.Text));
                    komut.Parameters.AddWithValue(("@tarih"), DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün Eklendi");
                }
                else
                {
                    MessageBox.Show("Böyle bir barkodno var", "Uyarı");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Aynı ürün 2 kez girilemez");
            }
            finally
            {
                baglanti.Close();
            }

            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            //if (BarkodNotxt.Text=="")
            //{
            //    lblMiktarı.Text = "";
            //    foreach (Control item in groupBox2.Controls)
            //    {
            //        if (item is TextBox)
            //        {
            //            item.Text = ""; 
            //        }
            //    }
            //}
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("select * from urun where barkodno like '"+BarkodNotxt.Text+"'", baglanti);
            //SqlDataReader read = komut.ExecuteReader();
            //while (read.Read()) 
            //{
            //    Kategoritxt.Text = read["kategori"].ToString();
            //    Markatxt.Text = read["marka"].ToString();
            //    ÜrünAdıtxt.Text = read["urunadi"].ToString();
            //    lblMiktarı.Text = read["miktari"].ToString();
            //    AlışFiyatıtxt.Text = read["alisfiyati"].ToString();
            //    SatışFiyatıtxt.Text = read["satisfiyati"].ToString();
            //}
            //baglanti.Close();
        }

        private void btnVarOlanaGüncelle_Click(object sender, EventArgs e)//Hatalı Açıldı (Böyle Bir Button yok )
        {
           
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("update urun set miktari = miktari +'" + int.Parse(Miktarıtxt.Text) + "' where barkodno = '" + BarkodNotxt.Text + "'", baglanti);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //foreach (Control item in groupBox2.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        item.Text = "";
            //    }
            //}
            //MessageBox.Show("Var olan ürüne ekleme yapıldı");
        }
    }
}

