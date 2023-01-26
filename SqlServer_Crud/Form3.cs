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
using System.Data.Sql;


namespace SqlServer_Crud
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=TTA;Integrated Security=True");

        private void btn_giris_Click(object sender, EventArgs e)
        {
          

            if (tb_kullanciAdi.Text == "" || tb_sifre.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ!");
            }
            else
            {

                string sorgu = "Select * from yonetici where kullanici_adi= '" + tb_kullanciAdi.Text.Trim() + "' and sifre = '" + tb_sifre.Text.Trim() + "'";

                SqlDataAdapter dataA = new SqlDataAdapter(sorgu, baglanti);
                DataTable dtbl = new DataTable();
                dataA.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                    tb_kullanciAdi.Clear();
                    tb_sifre.Clear();
                }
                else
                {
                    MessageBox.Show("GİRDİĞİNİZ BİLGİLER HATALI!");
                    tb_kullanciAdi.Clear();
                    tb_sifre.Clear();
                }



                /*


                 baglanti.Open();
                 SqlCommand komut = new SqlCommand("Select * from yonetici where kullanici_adi= '" + tb_kullanciAdi.Text + "' and sifre = '" + tb_sifre.Text + "'", baglanti);
                 SqlDataReader dr = komut.ExecuteReader();
                 if (dr.Read())
                 {
                     Form4 f4 = new Form4();
                     f4.Show();
                     tb_kullanciAdi.Clear();
                     tb_sifre.Clear();
                 }
                 else
                 {
                     MessageBox.Show("Kullanıcı adı veya şiresi yanlış");
                     tb_kullanciAdi.Clear();
                     tb_sifre.Clear();
                 }
                 baglanti.Close();
                

               
                string sorgu = "Select * from yonetici where kullanici_adi= '"+tb_kullanciAdi.Text.Trim()+"' and sifre = '"+tb_sifre.Text.Trim()+"'";

                SqlDataAdapter dataA = new SqlDataAdapter(sorgu, baglanti);
                DataTable dtbl = new DataTable();
                dataA.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                    tb_kullanciAdi.Clear();
                    tb_sifre.Clear();
                }
                else
                {
                    MessageBox.Show("GİRDİĞİNİZ BİLGİLER HATALI!");
                    tb_kullanciAdi.Clear();
                    tb_sifre.Clear();
                }
                */

            }

        }



            private void tb_kullanciAdi_TextChanged(object sender, EventArgs e)
            {

            }

        }

    }



