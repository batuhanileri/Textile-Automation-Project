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
    public partial class siparisguncelle : Form
    {
        public siparisguncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlCommand komut2;
        SqlCommand komut3;
        SqlDataAdapter da;


        int deger;

        

      
    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            deger = Int32.Parse(textBox1.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From Siparis WHERE Kumas_kodu=" + deger + "", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            //dataGridView1.DataSource = null;
            textBox5.Text = tablo.Rows[0][1].ToString();
            comboBox1.Text = tablo.Rows[0][3].ToString();
            textBox3.Text = tablo.Rows[0][4].ToString();
            dateTimePicker1.Text = tablo.Rows[0][2].ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            deger = Int32.Parse(textBox1.Text);
            baglanti = new SqlConnection("Data Source=DESKTOP-V21EQBH\\SQLEXPRESS;Initial Catalog = TEKSTİL OTOMASYONU; Integrated Security = True");




            string sorgu = "UPDATE Siparis SET urun_cesidi=@urun_cesidi,Sevkiyat_tarihi=@Sevkiyat_tarihi,Beden_Araligi=@Beden_Araligi,Siparis_Miktari=@Siparis_Miktari WHERE Kumas_kodu=" + deger + "";

            komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Calisan_id", textBox1.Text);
            komut.Parameters.AddWithValue("@urun_cesidi", textBox5.Text);
            komut.Parameters.AddWithValue("@Beden_Araligi", comboBox1.Text);
            komut.Parameters.AddWithValue("@Siparis_Miktari", textBox3.Text);
            komut.Parameters.AddWithValue("@Sevkiyat_tarihi", dateTimePicker1.Value);





            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();

            this.Close();

        }

        private void siparisguncelle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("XS");

            comboBox1.Items.Add("S");

            comboBox1.Items.Add("M");

            comboBox1.Items.Add("L");

            comboBox1.Items.Add("XL");
        }
    }
    }


