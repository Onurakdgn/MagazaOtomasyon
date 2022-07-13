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
    public partial class frmpgiris : Form
    {
        public frmpgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4BELAU0\SQLEXPRESS;Initial Catalog=magaza;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String sql = "select * from personelgiris where kullanici_adi=@kadi AND sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("kadi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", textBox2.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmSatis ana = new frmSatis();
                    ana.Show();
                   
                }
            }
            catch
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
