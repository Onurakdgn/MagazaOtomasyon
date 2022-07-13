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
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            satışlistele();
        }
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.adsoyad, u.barkod_no, u.urun_adi, u.satis_fiyati, se.miktar, s.tarih from satis s , urun u , sepet se , personel p " +
                "where s.personel_id = p.id and s.sepet_id = se.id and u.id = se.urun_id ", baglanti);
            da.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
