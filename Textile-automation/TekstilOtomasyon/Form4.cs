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
    public partial class Form4 : Form
    {
		
		SqlCommand komut2;
		SqlCommand komutkontrol;
		public Form4()
        {
            InitializeComponent();
        }
		static string conString = "Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True";
		//Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
		//Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
		SqlConnection baglanti1 = new SqlConnection(conString);
		public bool kontrol()
		{
			baglanti1.Open();
			string sorgu = "SELECT *From Siparis Where Kumas_Kodu=@Kumas_Kodu";
			komutkontrol = new SqlCommand(sorgu, baglanti1);
			komutkontrol.Parameters.AddWithValue("@Kumas_Kodu", Convert.ToInt32(textBox1.Text));
			SqlDataReader dt = komutkontrol.ExecuteReader();

			if (dt.Read())
			{
				baglanti1.Close();
				return false;


			}
			else
			{
				baglanti1.Close();
				return true;
			}
		}
			private void Form4_Load(object sender, EventArgs e)
        {
			comboBox1.Items.Add("XS");

			comboBox1.Items.Add("S");

			comboBox1.Items.Add("M");

			comboBox1.Items.Add("L");

			comboBox1.Items.Add("XL");
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			string sorgu2 = "INSERT INTO Siparis(Kumas_kodu,urun_cesidi,Sevkiyat_tarihi,Beden_Araligi,Siparis_Miktari) VALUES (@Kumas_kodu,@urun_cesidi,@Sevkiyat_tarihi,@Beden_Araligi,@Siparis_Miktari)";

			komut2 = new SqlCommand(sorgu2, baglanti1);
			komut2.Parameters.AddWithValue("@Kumas_kodu", textBox1.Text);
			komut2.Parameters.AddWithValue("@urun_cesidi", textBox2.Text);
			komut2.Parameters.AddWithValue("@Sevkiyat_tarihi", dateTimePicker1.Value);
			komut2.Parameters.AddWithValue("@Beden_Araligi", comboBox1.Text);
			komut2.Parameters.AddWithValue("@Siparis_Miktari", textBox3.Text);

			baglanti1.Open();



			komut2.ExecuteNonQuery();
			//	komut2.ExecuteNonQuery();

			baglanti1.Close();

			this.Close();
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
