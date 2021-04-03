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
    public partial class Form3 : Form
    {
        
        SqlCommand komut;
        SqlCommand komut2;
		SqlCommand komutkontrol;
		//SqlCommand komut3;
		public Form3()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti1= new SqlConnection(conString);
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
		public bool kontrol()
		{
			baglanti1.Open();
			string sorgu = "SELECT *From Kumas_Bilgisi Where Kumas_Kodu=@Kumas_Kodu";
			komutkontrol = new SqlCommand(sorgu, baglanti1);
			komutkontrol.Parameters.AddWithValue("@Kumas_Kodu", Convert.ToInt32(textBox6.Text));
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

		private void button2_Click(object sender, EventArgs e)
        {

			if (kontrol())
			{
				
				string sorgu = "INSERT INTO Kumas_Bilgisi(Kumas_kodu,Kumas_adi,Kumas_boyu,Kumas_eni,Kumas_rengi) VALUES (@Kumas_kodu,@Kumas_adi,@Kumas_boyu,@Kumas_eni,@Kumas_rengi)";
			//	string sorgu2 = "INSERT INTO kumas_Muhasebe(Kumas_kodu,Kumas_siparis_no,Kumas_irsaliye_no,Kumas_mkare_fiyati,Kumas_adeti) VALUES (@Kumas_kodu,@Kumas_siparis_no,@Kumas_irsaliye_no,@Kumas_mkare_fiyati,@Kumas_adeti)";

				komut = new SqlCommand(sorgu, baglanti1);
				komut.Parameters.AddWithValue("@Kumas_kodu", textBox6.Text);
				komut.Parameters.AddWithValue("@Kumas_adi", textBox15.Text);
				komut.Parameters.AddWithValue("@Kumas_boyu", textBox14.Text);
				komut.Parameters.AddWithValue("@Kumas_eni", textBox13.Text);
				komut.Parameters.AddWithValue("@Kumas_rengi", textBox8.Text);

				/*	komut2 = new SqlCommand(sorgu2, baglanti1);
					komut2.Parameters.AddWithValue("@Kumas_kodu", textBox6.Text);
					komut2.Parameters.AddWithValue("@Kumas_irsaliye_no", textBox7.Text);
					komut2.Parameters.AddWithValue("@Kumas_mkare_fiyati", textBox19.Text);
					komut2.Parameters.AddWithValue("@Kumas_adeti", textBox18.Text);
					komut2.Parameters.AddWithValue("@Kumas_siparis_no", textBox17.Text);

		*/
				baglanti1.Open();



				komut.ExecuteNonQuery();
			//	komut2.ExecuteNonQuery();

				baglanti1.Close();

				this.Close();
			}
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

        }

        
    }
}
