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
    public partial class frmKategoriSil : Form
    {
        public frmKategoriSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");
        DataSet daset = new DataSet();

        private void frmKategoriSil_Load(object sender, EventArgs e)
        {

        }
        private void kategorilistele()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select kategori_adi from kategori", baglanti);
            da.Fill(daset, "kategori");
            dataGridView1.DataSource = daset.Tables["kategori"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kategori where kategori_adi='" + dataGridView1.CurrentRow.Cells["kategori_adi"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["kategori"].Clear();
                kategorilistele();
                MessageBox.Show("Kayıt Silindi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bu kategori silinememektedir.");
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
