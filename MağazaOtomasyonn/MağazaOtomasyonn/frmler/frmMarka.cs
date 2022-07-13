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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");

        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from marka", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text == read["kategori_id"].ToString() && textBox1.Text == read["marka_adi"].ToString() || comboBox1.Text== "" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                int kategoriId = 0;
                baglanti.Open();
                SqlCommand komutKategoriId = new SqlCommand("select id from kategori where kategori_adi = '" + comboBox1.Text + "'", baglanti);
                SqlDataReader read = komutKategoriId.ExecuteReader();
                while (read.Read())
                {
                    kategoriId = Int32.Parse(read["id"].ToString());

                }
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into marka(kategori_id,marka_adi)values('" + kategoriId + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var", "Uyarı");
            }


            textBox1.Text = "";
            comboBox1.Text = "";
        }
        
        private void frmMarka_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(read["kategori_adi"].ToString());
            }
            baglanti.Close();
        }
    }
}
