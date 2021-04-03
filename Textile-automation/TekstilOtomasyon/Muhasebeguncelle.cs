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
namespace TekstilOtomasyon
{
    public partial class muhasebeguncelle : Form
    {
        public muhasebeguncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        
        SqlDataAdapter da;
       
        int deger;

        private void button1_Click(object sender, EventArgs e)
        {
            deger = Int32.Parse(textBox1.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From Kumas_Muhasebe WHERE Kumas_kodu=" + deger + "", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            //dataGridView1.DataSource = null;
            textBox5.Text = tablo.Rows[0][1].ToString();
            textBox4.Text = tablo.Rows[0][2].ToString();
            textBox3.Text = tablo.Rows[0][3].ToString();
            textBox2.Text = tablo.Rows[0][4].ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            deger = Int32.Parse(textBox1.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");




            string sorgu = "UPDATE Kumas_Muhasebe SET Kumas_siparis_no=@Kumas_siparis_no,Kumas_irsaliye_no=@Kumas_irsaliye_no,Kumas_mkare_fiyati=@Kumas_mkare_fiyati,Kumas_adeti=@Kumas_adeti WHERE Kumas_kodu=" + deger + "";
            
            komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
            komut.Parameters.AddWithValue("@Kumas_siparis_no", textBox5.Text);
            komut.Parameters.AddWithValue("@Kumas_irsaliye_no", textBox4.Text);
            komut.Parameters.AddWithValue("@Kumas_mkare_fiyati", textBox3.Text);
            komut.Parameters.AddWithValue("@Kumas_adeti", textBox2.Text);
            
            


            baglanti.Open();

            komut.ExecuteNonQuery();
            
            baglanti.Close();
            
            this.Close();
        }
    }
}
