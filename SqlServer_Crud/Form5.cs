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

namespace SqlServer_Crud
{
    public partial class Form5 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=TTA;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter sda;

        public Form5()
        {
            InitializeComponent();
        }

        private void btn_uret_Click(object sender, EventArgs e)
        {
            int minL = 4;
            int maxL = 12;

            string charAvaliable = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ1234567890";

            StringBuilder pw = new StringBuilder();
            Random rdm = new Random();

            int pwLength = rdm.Next(minL, maxL + 1);

            while (pwLength-- > 0)
            {
                pw.Append(charAvaliable[rdm.Next(charAvaliable.Length)]);
            }

            tb_parola.Text = pw.ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if(tb_adSoyad.Text == "" || tb_mail.Text == "" || tb_parola.Text == "")
            {
                MessageBox.Show("Boş Yer Bırakılamaz.");
            }
            else
            {
                string sorgu = "INSERT INTO kullanici(ad_soyad, kullanici_ismi, parola) VALUES (@ad_soyad, @kullanici_ismi, @parola)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad_soyad", tb_adSoyad.Text);
                komut.Parameters.AddWithValue("@kullanici_ismi", tb_mail.Text);
                komut.Parameters.AddWithValue("@parola", tb_parola.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Bilgiler Tamamdır.");

                string sorgu1 = "INSERT INTO Yonetici(kullanici_adi, sifre) VALUES (@kullanici_adi, @sifre)";
                komut = new SqlCommand(sorgu1, baglanti);
                komut.Parameters.AddWithValue("@kullanici_adi", tb_mail.Text);
                komut.Parameters.AddWithValue("@sifre", tb_parola.Text);
                
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
