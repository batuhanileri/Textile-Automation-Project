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
	public partial class Form25 : Form
	{
		
		SqlCommand komut2;
		SqlCommand komutkontrol;
		public Form25()
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
			string sorgu = "SELECT *From Kumas_Muhasebe Where Kumas_Kodu=@Kumas_Kodu";
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
		private void button1_Click(object sender, EventArgs e)
		{

			string sorgu2 = "INSERT INTO kumas_Muhasebe(Kumas_kodu,Kumas_siparis_no,Kumas_irsaliye_no,Kumas_mkare_fiyati,Kumas_adeti) VALUES (@Kumas_kodu,@Kumas_siparis_no,@Kumas_irsaliye_no,@Kumas_mkare_fiyati,@Kumas_adeti)";

			komut2 = new SqlCommand(sorgu2, baglanti1);
			komut2.Parameters.AddWithValue("@Kumas_kodu", textBox1.Text);
			komut2.Parameters.AddWithValue("@Kumas_irsaliye_no", textBox3.Text);
			komut2.Parameters.AddWithValue("@Kumas_mkare_fiyati", textBox2.Text);
			komut2.Parameters.AddWithValue("@Kumas_adeti", textBox5.Text);
			komut2.Parameters.AddWithValue("@Kumas_siparis_no", textBox4.Text);

			baglanti1.Open();



			komut2.ExecuteNonQuery();
			//	komut2.ExecuteNonQuery();

			baglanti1.Close();

			this.Close();
		}
	}
}
