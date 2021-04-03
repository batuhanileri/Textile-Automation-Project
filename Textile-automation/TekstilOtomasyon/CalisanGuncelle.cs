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
	public partial class CalisanGuncelle : Form
	{
		public CalisanGuncelle()
		{
			InitializeComponent();
		}
		SqlConnection baglanti;
		SqlCommand komut;
		SqlCommand komut2;
		SqlCommand komut3;
		SqlDataAdapter da;
		SqlDataAdapter da1;
		SqlDataAdapter da2;
		int deger;
		private void CalisanGuncelle_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			deger = Int32.Parse(textBox1.Text);
			baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
			baglanti.Open();
			da = new SqlDataAdapter("Select *From Calisan_bilgi WHERE Calisan_id="+deger+"", baglanti);
			DataTable tablo = new DataTable();
			da.Fill(tablo);
			//dataGridView1.DataSource = null;
			textBox2.Text= tablo.Rows[0][1].ToString();
			textBox3.Text = tablo.Rows[0][2].ToString();
			textBox4.Text = tablo.Rows[0][7].ToString();
			textBox5.Text = tablo.Rows[0][5].ToString();
			textBox6.Text = tablo.Rows[0][4].ToString();
			textBox8.Text = tablo.Rows[0][6].ToString();

			da1 = new SqlDataAdapter("Select *From Calisan_İK WHERE Calisan_id ="+deger+"", baglanti);
			DataTable tablo2 = new DataTable();
			da1.Fill(tablo2);
			textBox9.Text = tablo2.Rows[0][1].ToString();
			textBox10.Text = tablo2.Rows[0][2].ToString();
			textBox11.Text = tablo2.Rows[0][3].ToString();
			textBox12.Text = tablo2.Rows[0][4].ToString();


			da2 = new SqlDataAdapter("Select *From Departman WHERE Calisan_id =" + deger + "", baglanti);
			DataTable tablo3 = new DataTable();
			da2.Fill(tablo3);
			textBox13.Text = tablo3.Rows[0][1].ToString();
			baglanti.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form30 form30 = new Form30();
			deger = Int32.Parse(textBox1.Text);
			baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
			

			string sorgu = "UPDATE Calisan_bilgi SET Adı=@Adı,Soyadı=@Soyadı,T_C_No=@T_C_No,Adres=@Adres,Kan_Grubu=@Kan_Grubu,Dogum_Tarihi=@Dogum_Tarihi,E_posta=@E_posta WHERE Calisan_id=" + deger + "";
			string sorgu2 = "UPDATE Calisan_İK SET  Maas= @Maas,Ek_mesai=@Ek_mesai,Calisma_baslama_saati=@Calisma_baslama_saati,Calisma_bitis_saati=@Calisma_bitis_saati WHERE Calisan_id=" + deger + "";
			string sorgu3 = "UPDATE Departman SET departman_ad=@departman_ad WHERE Calisan_id=" + deger + "";

			komut = new SqlCommand(sorgu, baglanti);
			//komut.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
			komut.Parameters.AddWithValue("@Adı", textBox2.Text);
			komut.Parameters.AddWithValue("@Soyadı", textBox3.Text);
			komut.Parameters.AddWithValue("@T_C_No", textBox4.Text);
			komut.Parameters.AddWithValue("@Adres", textBox5.Text);
			komut.Parameters.AddWithValue("@Kan_Grubu", textBox6.Text);
			komut.Parameters.AddWithValue("@Dogum_Tarihi", dateTimePicker1.Value);
			komut.Parameters.AddWithValue("@E_posta", textBox8.Text);
			komut2 = new SqlCommand(sorgu2, baglanti);
			//komut2.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
			komut2.Parameters.AddWithValue("@Maas", textBox9.Text.ToString());
			komut2.Parameters.AddWithValue("@Ek_mesai", textBox10.Text.ToString());
			komut2.Parameters.AddWithValue("@Calisma_baslama_saati", textBox11.Text);
			komut2.Parameters.AddWithValue("@Calisma_bitis_saati", textBox12.Text);

			komut3 = new SqlCommand(sorgu3, baglanti);
			//komut3.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
			komut3.Parameters.AddWithValue("@departman_ad", textBox13.Text);



			baglanti.Open();
			
			komut.ExecuteNonQuery();
			komut2.ExecuteNonQuery();
			komut3.ExecuteNonQuery();
			baglanti.Close();
			form30.Guncelle();
			this.Close();

		}
	}
}
