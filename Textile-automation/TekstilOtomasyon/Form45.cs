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
    public partial class Form45 : Form
    {
		public static bool tablo1 = false;
		public static bool tablo2 = false;
		public static bool tablo3 = false;
        public static bool tablo4 = false;
        SqlCommand komut;
		SqlDataAdapter da;
		public Form45()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
		public void TabloGetir1()
		{
			baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
			baglanti.Open();
			da = new SqlDataAdapter("Select *From Kumas_Bilgisi", baglanti);
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
			da = new SqlDataAdapter("Select *From Kumas_Muhasebe", baglanti);
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
			da = new SqlDataAdapter("Select *From Siparis", baglanti);
			DataTable tablo = new DataTable();

			da.Fill(tablo);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = tablo;
			baglanti.Close();
		}
        public void TabloGetir4()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From Pastal", baglanti);
            DataTable tablo = new DataTable();

            da.Fill(tablo);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public object TEKSTİL_OTOMASYONUDataSet { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();

            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();

            f8.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void kayitGetir()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
			tablo1 = true;
			tablo2 = false;
			tablo3 = false;
            tablo4 = false;
            TabloGetir1();
		}

        private void Form5_Load(object sender, EventArgs e)
        {
          //  this.kumas_BilgisiTableAdapter.Fill(this.tEKSTİL_OTOMASYONUDataSet.Kumas_Bilgisi);
            // TODO: Bu kod satırı 'tEKSTİL_OTOMASYONUDataSet.Kumas_Muhasebe' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.//    this.kumas_MuhasebeTableAdapter.Fill(this.TEKSTİL_OTOMASYONUDataSet.Kumas_Muhasebe);
        }

		private void kumasBilgisiBindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			Form25 f25 = new Form25();
			f25.ShowDialog();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			tablo1 = false;
			tablo2 = true;
			tablo3 = false;
            tablo4 = false;
            TabloGetir2();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			tablo1 = false;
			tablo2 = false;
			tablo3 = true;
            tablo4 = false;
            TabloGetir3();
		}

		private void button8_Click(object sender, EventArgs e)
		{
            tablo1 = false;
            tablo2 = false;
            tablo3 = false;
            tablo4 = true;
            TabloGetir4();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }
    }
}
