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
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");
        DataSet dataSet = new DataSet();

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

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            Kategorigetir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select u.barkod_no , k.kategori_adi, m.marka_adi, u.miktar,u.urun_adi,u.alis_fiyati, u.satis_fiyati " +
                "from urun u,kategori k  ,marka m where u.kategori_id = k.id and u.marka_id = m.id", baglanti);
            da.Fill(dataSet, "urun");
            dataGridView1.DataSource = dataSet.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkod_no"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori_adi"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka_adi"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alis_fiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satis_fiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urun_adi=@urunadi,miktar=@miktar,alis_fiyati=@alisfiyati,satis_fiyati=@satis_fiyati where barkod_no=@barkodno", baglanti);
            komut.Parameters.AddWithValue("barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("urunadi", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("miktar", int.Parse(Miktarıtxt.Text));
            komut.Parameters.AddWithValue("alisfiyati", double.Parse(AlışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("satis_fiyati", double.Parse(SatışFiyatıtxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Güncelleme Yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text != "")
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
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update urun set kategori_id=@kategori,marka_id=@marka where barkod_no=@barkodno", baglanti);
                    komut.Parameters.AddWithValue("barkodno", BarkodNotxt.Text);
                    komut.Parameters.AddWithValue("kategori", kategoriId);
                    komut.Parameters.AddWithValue("marka", markaId);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Güncelleme Yapıldı");
                    dataSet.Tables["urun"].Clear();
                    ÜrünListele();
                }
                catch (SqlException eZ)
                {
                    MessageBox.Show("Ürün var olan bir kategori-marka ikilisine güncellenemez");
                }
                finally
                {
                    baglanti.Close();
                }



            }
            else
            {
                MessageBox.Show("Barkod No Yazılı Değil!!");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
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
            SqlCommand komut = new SqlCommand("select * from marka where kategori_id='" + kategoriId + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka_adi"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
