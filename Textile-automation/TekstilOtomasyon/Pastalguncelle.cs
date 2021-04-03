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
    public partial class pastalguncelle : Form
    {
        public pastalguncelle()
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
            da = new SqlDataAdapter("Select *From Pastal WHERE Kumas_kodu=" + deger + "", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            
            textBox2.Text = tablo.Rows[0][1].ToString();
            textBox3.Text = tablo.Rows[0][2].ToString();
            textBox4.Text = tablo.Rows[0][3].ToString();
            textBox5.Text = tablo.Rows[0][5].ToString();
            textBox6.Text = tablo.Rows[0][4].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            deger = Int32.Parse(textBox1.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");




            string sorgu = "UPDATE Pastal SET pastal_atan=@pastal_atan,pastal_kesen=@pastal_kesen,pastal_meto=@pastal_meto,pastal_toplama=@pastal_toplama,pastal_yetkilisi=@pastal_yetkilisi WHERE Kumas_kodu=" + deger + "";

            komut = new SqlCommand(sorgu, baglanti);
            
            komut.Parameters.AddWithValue("@pastal_atan", textBox2.Text);
            komut.Parameters.AddWithValue("@pastal_kesen", textBox3.Text);
            komut.Parameters.AddWithValue("@pastal_meto", textBox4.Text);
            komut.Parameters.AddWithValue("@pastal_toplama", textBox6.Text);
            komut.Parameters.AddWithValue("@pastal_yetkilisi", textBox5.Text);


            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();

            this.Close();
        
    }
    }
}
