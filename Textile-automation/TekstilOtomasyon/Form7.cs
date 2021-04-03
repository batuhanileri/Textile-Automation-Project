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
    public partial class Form7 : Form
    {
        SqlCommand komut2;
        
        SqlCommand komutkontrol;

        static string conString = "Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti1 = new SqlConnection(conString);

        public bool kontrol()
        {
            baglanti1.Open();
            string sorgu = "SELECT *From Pastal Where Kumas_Kodu=@Kumas_Kodu";
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

        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            string sorgu2 = "INSERT INTO Pastal(Kumas_kodu,pastal_atan,pastal_kesen,pastal_meto,pastal_toplama,pastal_yetkilisi) VALUES (@Kumas_kodu,@pastal_atan,@pastal_kesen,@pastal_meto,@pastal_yetkilisi,@pastal_toplama)";

            komut2 = new SqlCommand(sorgu2, baglanti1);
            komut2.Parameters.AddWithValue("@Kumas_kodu", textBox1.Text);
            komut2.Parameters.AddWithValue("@pastal_atan", textBox6.Text);
            komut2.Parameters.AddWithValue("@pastal_toplama", textBox2.Text);
            komut2.Parameters.AddWithValue("@pastal_meto", textBox4.Text);
            komut2.Parameters.AddWithValue("@pastal_yetkilisi", textBox3.Text);
            komut2.Parameters.AddWithValue("@pastal_kesen", textBox5.Text);

            baglanti1.Open();



            komut2.ExecuteNonQuery();
            

            baglanti1.Close();

            this.Close();
        }
	}
}
