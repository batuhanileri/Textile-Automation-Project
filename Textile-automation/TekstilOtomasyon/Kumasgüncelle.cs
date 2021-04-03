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
    public partial class Kumasgüncelle : Form
    {
        public Kumasgüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlCommand komut2;
        SqlCommand komut3;
        SqlDataAdapter da;
        
        
        int deger;

        private void button1_Click(object sender, EventArgs e)
        {
            deger = Int32.Parse(textBox6.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From Kumas_Bilgisi WHERE Kumas_kodu=" + deger + "", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            //dataGridView1.DataSource = null;
            textBox1.Text = tablo.Rows[0][1].ToString();
            textBox2.Text = tablo.Rows[0][2].ToString();
            textBox3.Text = tablo.Rows[0][3].ToString();
            textBox4.Text = tablo.Rows[0][4].ToString();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            deger = Int32.Parse(textBox6.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");




            string sorgu = "UPDATE Kumas_Bilgisi SET Kumas_adi=@Kumas_adi,Kumas_boyu=@Kumas_boyu,Kumas_eni=@Kumas_eni,Kumas_rengi=@Kumas_rengi WHERE Kumas_kodu=" + deger + "";
            
            komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
            komut.Parameters.AddWithValue("@Kumas_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@Kumas_boyu", textBox2.Text);
            komut.Parameters.AddWithValue("@Kumas_eni", textBox3.Text);
            komut.Parameters.AddWithValue("@Kumas_rengi", textBox4.Text);
            
            



            baglanti.Open();

            komut.ExecuteNonQuery();
            
            baglanti.Close();
            
            this.Close();

        }
    }
    }

