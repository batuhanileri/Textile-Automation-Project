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
	public partial class Degeral : Form
	{
		
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
		SqlCommand komut;
		SqlCommand komut2;
		SqlCommand komut3;
		SqlCommand komutkontrol;
		SqlDataAdapter da;



		public Degeral()
		{
			InitializeComponent();
		}

		public bool kontrol()
		{
			baglanti.Open();
			string sorgu = "SELECT *From Calisan_bilgi Where Calisan_id=@Calisan_id";
			komutkontrol = new SqlCommand(sorgu, baglanti);
			komutkontrol.Parameters.AddWithValue("@Calisan_id", Convert.ToInt32(textBox1.Text));
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

		private void button1_Click(object sender, EventArgs e)
		{
			Form30 form30 = new Form30();


			if (kontrol())
			{
				string sorgu =  "Delete From Calisan_bilgi Where Calisan_id=@Calisan_id";
				string sorgu2 = "Delete From Calisan_İK Where Calisan_id=@Calisan_id";
				string sorgu3 = "Delete From Departman Where Calisan_id=@Calisan_id";
				komut = new SqlCommand(sorgu, baglanti);
				komut2 = new SqlCommand(sorgu2, baglanti);
				komut3 = new SqlCommand(sorgu3, baglanti);
				komut.Parameters.AddWithValue("@Calisan_id", Convert.ToInt32(textBox1.Text));
				komut2.Parameters.AddWithValue("@Calisan_id", Convert.ToInt32(textBox1.Text));
				komut3.Parameters.AddWithValue("@Calisan_id", Convert.ToInt32(textBox1.Text));

				baglanti.Open();
				komut.ExecuteNonQuery();
				komut2.ExecuteNonQuery();
				komut3.ExecuteNonQuery();
				baglanti.Close();
				form30.Guncelle();

				this.Close();
			}
			else
				MessageBox.Show("Geçersiz ID Numarası", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}
	}
}
