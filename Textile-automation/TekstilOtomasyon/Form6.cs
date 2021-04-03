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
    public partial class Form6 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
        SqlCommand komut;
        
        SqlCommand komutkontrol;
      
        public bool kontrol()
        {
            baglanti.Open();
            string sorgu = "SELECT *From Kumas_Bilgisi Where Kumas_kodu=@Kumas_kodu";
            komutkontrol = new SqlCommand(sorgu, baglanti);
            komutkontrol.Parameters.AddWithValue("@Kumas_kodu", Convert.ToInt32(textBox1.Text));
            SqlDataReader dt = komutkontrol.ExecuteReader();

            if (dt.Read())
            {
                baglanti.Close();
                return true;


            }
            else
            {
                baglanti.Close();
                return false;
            }

        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            
           

            if (kontrol())
            {
                string sorgu = "Delete From Kumas_Bilgisi Where Kumas_kodu=@Kumas_kodu";
             
                komut = new SqlCommand(sorgu, baglanti);
            
                komut.Parameters.AddWithValue("@Kumas_kodu", Convert.ToInt32(textBox1.Text));
             

                baglanti.Open();
                komut.ExecuteNonQuery();
           
                baglanti.Close();
               // form3.Guncelle();

                this.Close();
            }
            else
                MessageBox.Show("Geçersiz ID Numarası", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }

    }

