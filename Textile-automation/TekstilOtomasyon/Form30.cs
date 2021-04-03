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
	public partial class Form30 : Form
	{
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
		SqlCommand komut;
		SqlCommand komut2;
		SqlCommand komut3;
		SqlDataAdapter da;
		SqlCommand komutkontrol;
		public Form30()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
		{

		}
	public	void Guncelle() {
		
			

			if (Form2.tablo1)
			{


				Form2 obj = (Form2)Application.OpenForms["Form2"];
				obj.TabloGetir1();
				obj.dataGridView1.Update();
				obj.dataGridView1.Refresh();
			}
			if (Form2.tablo2)
			{



				Form2 obj = (Form2)Application.OpenForms["Form2"];
				obj.TabloGetir2();
				obj.dataGridView1.Update();
				obj.dataGridView1.Refresh();
			}
			if (Form2.tablo3)
			{



				Form2 obj = (Form2)Application.OpenForms["Form2"];
				obj.TabloGetir3();
				obj.dataGridView1.Update();
				obj.dataGridView1.Refresh();
			}
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
				return false;


			}
			else
			{
				baglanti.Close();
				return true;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{


			if (kontrol())
			{
				string sorgu = "insert into Calisan_bilgi(Calisan_id,Ad,Soyad,Tc_No,Adres,Kan_Grubu,Dogum_Tarihi,E_posta) VALUES (@Calisan_id,@Ad,@Soyad,@Tc_No,@Adres,@Kan_Grubu,@Doğum_Tarihi,@E_posta)";
				string sorgu2 = "insert into Calisan_İK(Calisan_id,Maas,Ek_mesai,Calisma_baslama_saati,Calisma_bitis_saati) VALUES (@Calisan_id,@Maas,@Ek_mesai,@Calisma_baslama_saati,@Calisma_bitis_saati)";
				string sorgu3 = "insert into Departman (Calisan_id,departman_ad)VALUES(@Calisan_id,@departman_ad)";

				komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
				komut.Parameters.AddWithValue("@Ad", textBox2.Text);
				komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
				komut.Parameters.AddWithValue("@Tc_No", textBox4.Text);
				komut.Parameters.AddWithValue("@Adres", textBox5.Text);
				komut.Parameters.AddWithValue("@Kan_Grubu", textBox6.Text);
				komut.Parameters.AddWithValue("@Doğum_Tarihi", dateTimePicker1.Value);
				komut.Parameters.AddWithValue("@E_posta", textBox8.Text);
				komut2 = new SqlCommand(sorgu2, baglanti);
				komut2.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
				komut2.Parameters.AddWithValue("@Maas", textBox9.Text.ToString());
				komut2.Parameters.AddWithValue("@Ek_mesai", textBox10.Text.ToString());
				komut2.Parameters.AddWithValue("@Calisma_baslama_saati", textBox11.Text);
				komut2.Parameters.AddWithValue("@Calisma_bitis_saati", textBox12.Text);

				komut3 = new SqlCommand(sorgu3, baglanti);
				komut3.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
				komut3.Parameters.AddWithValue("@departman_ad", comboBox1.Text);


				baglanti.Open();



				komut.ExecuteNonQuery();
				komut2.ExecuteNonQuery();
				komut3.ExecuteNonQuery();


				baglanti.Close();

				this.Close();
				Guncelle();
			}
			else
				MessageBox.Show("Kullanıcı Zaten Var!!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);



		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Form30_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Pastal Atan");

			comboBox1.Items.Add("Pastal Kesen");

			comboBox1.Items.Add("Meto Basan");

			comboBox1.Items.Add("Pastal Toplama");

			comboBox1.Items.Add("Pastal Yetkilisi");


		}
	}
}
