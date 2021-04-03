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
    public partial class Form2 : Form
    {
		public static bool tablo1=false;
		public static bool tablo2 = false;
		public static bool tablo3 = false;
		SqlConnection baglanti;
		SqlCommand komut;
		SqlDataAdapter da;
		public Form2()
		{
			InitializeComponent();

		}
		public void TabloGetir1()
		{
			baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
			baglanti.Open();
			da = new SqlDataAdapter("Select *From Calisan_bilgi", baglanti);
			DataTable tablo = new DataTable();
			
			da.Fill(tablo);
			this.dataGridView1.DataSource = null;
			this.dataGridView1.DataSource = tablo;

			baglanti.Close();
		}

 		public void TabloGetir2()
		{
			baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
			baglanti.Open();
			da = new SqlDataAdapter("Select *From Calisan_İK", baglanti);
			DataTable tablo = new DataTable();

			da.Fill(tablo);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = tablo;
			baglanti.Close();
		}
		public void TabloGetir3()
		{
			baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
			baglanti.Open();
			da = new SqlDataAdapter("Select *From Departman ", baglanti);
			DataTable tablo = new DataTable();
			da.Fill(tablo);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = tablo;
			baglanti.Close();
		}


		private void button1_Click(object sender, EventArgs e)
        {
			
            Form30 f30 = new Form30();

            f30.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

		private void button6_Click(object sender, EventArgs e)
		{
			tablo1 = true;
			tablo2 = false;
			tablo3 = false;

			TabloGetir1();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			tablo1 = false;
			tablo2 = true;
			tablo3 = false;

			TabloGetir2();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			tablo1 = false;
			tablo2 = false;
			tablo3 = true;

			TabloGetir3();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			Degeral degeral = new Degeral();
			degeral.Show();

			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CalisanGuncelle a = new CalisanGuncelle();
			a.Show();
		}

		public void button4_Click(object sender, EventArgs e)
		{
			TabloGetir1();
		}
	}
}
