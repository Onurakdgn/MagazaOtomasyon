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
    public partial class frmSatis : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            string da = ("select u.barkod_no , u.urun_adi, s.miktar, u.satis_fiyati, s.toplam_fiyat, s.tarih from sepet s,urun u where s.urun_id =u.id and s.deleted != 1 ");
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
            {
                baglanti.Open();
                using( SqlDataAdapter dat = new SqlDataAdapter(da, baglanti))
                {

                    dat.Fill(daset, "sepet");
                    dataGridView1.DataSource = daset.Tables["sepet"];


                }
            }
        }
        public frmSatis()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void müşteriListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüşteriListeleme listele = new frmMüşteriListeleme();
            listele.ShowDialog();
        }

        private void ürünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÜrünEKle eKle = new frmÜrünEKle();
            eKle.ShowDialog();
        }

        private void ürünListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void kategoriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void markaEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
            
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "Tl";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel where tc ='" + txtTC.Text + "' and deleted !=1", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void TxtUrunID_TextChanged(object sender, EventArgs e)
        {
            string komut = "select * from urun where barkod_no = '" + txtBarkodNo.Text + "'";
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
            {
                baglanti.Open();
                using (SqlCommand cmd = new SqlCommand(komut, baglanti))
                {

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            txtürunAdı.Text = read[8].ToString();
                            txtSatışFiyati.Text = read[6].ToString();
                        }
                    }
                }
            }

        }
        
        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    } 
                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            string komut = "select u.barkod_no from sepet s , urun u where s.urun_id = u.id and s.deleted !=1";
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
            {
                baglanti.Open();
                using (SqlCommand cmd = new SqlCommand(komut, baglanti))
                {

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            if (txtBarkodNo.Text == read["barkod_no"].ToString())
                            {
                                durum = false;
                            }
                        }
                    }
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                int urunId = 0;

                string komut1 = "select id from urun where barkod_no = '" + txtBarkodNo.Text + "'";
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand kmt9 = new SqlCommand(komut1, baglanti))
                    {
                        using (SqlDataReader read = kmt9.ExecuteReader())
                            while (read.Read())
                            {
                                urunId = Int32.Parse(read["id"].ToString());
                            }
                    }
                }

                string komut7 = ("insert into sepet(urun_id,miktar,toplam_fiyat,tarih) values(@urun_id,@miktar,@toplam_fiyat,@tarih)");
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand kmt01 = new SqlCommand(komut7, baglanti))
                    {
                        kmt01.Parameters.AddWithValue("miktar", txtMiktari.Text);
                        kmt01.Parameters.AddWithValue("urun_id", urunId);
                        kmt01.Parameters.AddWithValue("toplam_fiyat", double.Parse(txtToplamFiyati.Text));
                        kmt01.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                        kmt01.ExecuteNonQuery();
                        
                    }
                }
            }
            else
            {
                string komut8 = ("update sepet set miktar=miktar+'" + int.Parse(txtMiktari.Text) + "' where urun_id=(select id from urun where barkod_no ='" + txtBarkodNo.Text + "')");
                string komut9 = ("update sepet set toplam_fiyat=miktar*(select satis_fiyati from urun where barkod_no='" + txtBarkodNo.Text + "') ");

                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand kmt02 = new SqlCommand(komut8, baglanti))
                    {
                        kmt02.ExecuteNonQuery();
                    }
                    using (SqlCommand kmt03 = new SqlCommand(komut9, baglanti))
                    {
                        kmt03.ExecuteNonQuery();

                    }
                }
            }
            txtMiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }

            }
        }
    

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMiktari.Text)  * double.Parse(txtSatışFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatışFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string komut10 = ("update sepet set deleted = 1 where urun_id = (select id from urun where barkod_no = '" + dataGridView1.CurrentRow.Cells["barkod_no"].Value.ToString() + "')");

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
            {
                baglanti.Open();
                using (SqlCommand kmt10 = new SqlCommand(komut10, baglanti))
                {
                    kmt10.ExecuteNonQuery();
                } 
            }
                MessageBox.Show("Ürün Sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void satışlarıListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.ShowDialog();
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            string komut11 = ("update sepet set deleted = 1");

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
            {
                baglanti.Open();
                using (SqlCommand kmt11 = new SqlCommand(komut11, baglanti))
                {
                    kmt11.ExecuteNonQuery();
                }
            }
                MessageBox.Show("Ürünler Sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            int personelId=1 ;
            int sepetId=1 ;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string komut1 = "select id from personel where tc ='" + txtTC.Text + "' and deleted != 1";
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand komutPeronelId = new SqlCommand(komut1, baglanti))
                    {

                        using (SqlDataReader read = komutPeronelId.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                personelId = Int32.Parse(read["id"].ToString());
                                Console.WriteLine(personelId);
                            }
                        }
                    }
                }


                string komut2 = "select id from sepet  where tarih = '" + dataGridView1.Rows[i].Cells["tarih"].Value.ToString() + "'";
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand komutSepetId = new SqlCommand(komut2, baglanti))
                    {

                        using (SqlDataReader read = komutSepetId.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                sepetId = Int32.Parse(read["id"].ToString());
                                Console.WriteLine(sepetId);
                            }
                        }
                    }
                }
                string komut5 = ("insert into satis(personel_id, sepet_id,tarih) values(@personel_id,@sepet_id,@tarih)");
                string komut6 = ("update urun set miktar=miktar-'" + int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()) + "'where barkod_no='" + dataGridView1.Rows[i].Cells["barkod_no"].Value.ToString() + "'");

                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand kmt = new SqlCommand(komut5, baglanti))
                    {
                        kmt.Parameters.AddWithValue("personel_id", personelId);
                        kmt.Parameters.AddWithValue("sepet_id", sepetId);
                        kmt.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                        kmt.ExecuteNonQuery();
                    }
                    using (SqlCommand kmt2 = new SqlCommand(komut6, baglanti))
                    {
                        kmt2.ExecuteNonQuery();

                    }

                }

            }
            string komut7 = ("update sepet set deleted = 1");


            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True"))
            {
                baglanti.Open();
                using (SqlCommand kmt7 = new SqlCommand(komut7, baglanti))
                {

                    kmt7.ExecuteNonQuery();
                }

                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
            }

        }

        private void kategoriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriSil ktsil = new frmKategoriSil();
            ktsil.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
