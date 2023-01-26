using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SqlServer_Crud
{
    public partial class Form2 : Form
    {


       

        public Form2()
        {
            InitializeComponent();
        }



        void Yenile()
        {



        }

        SqlDataReader dr;
        DataTable dt = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=TTA;Integrated Security=True");
        SqlCommand komut = new SqlCommand();



        private void Form2_Load(object sender, EventArgs e)
        {


            comboBox1.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select t1.Deger, t2.Acıklama from Eklee t1, Acıklaa t2 where t1.ID = t2.ID";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
                
              
            }
            
            baglanti.Close();
           
            /*
            // CBBolum();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Acıklaa");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            dr = komut.ExecuteReader();

            dt.Load(dr);

            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "Deger";
            comboBox1.ValueMember = "Deger ";
            baglanti.Close();

*/

            /*
            comboBox1.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select *from Acıklaa";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }

            baglanti.Close();

*/
            /*
                        comboBox1.Items.Clear();
                        SqlDataReader oku;
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "select *from Eklee";
                        oku = komut.ExecuteReader();
                        while (oku.Read())
                        {
                            comboBox1.Items.Add(oku[0].ToString());
                        }

                        baglanti.Close();


                 */
            /*
                        ToplamUretilen();

              */
        }
        private void CBBolum()
        {
            //comboBox1.DataSource = null;
            //
            //cnn.Open();
            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = "SELECT bolumad FROM BolumTbl";
            //komut.Connection = cnn;
            //komut.CommandType = CommandType.Text;

            //SqlDataReader dr;

            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr["bolumad"]);
            //}
            //cnn.Close();
/*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Acıklaa");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            dr = komut.ExecuteReader();

            dt.Load(dr);

            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "Deger";
            comboBox1.ValueMember = "ID ";
            baglanti.Close();

*/

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAriza_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugunTarihi = DateTime.Now;
            DateTime arizaTarihi = dateTimePicker1.Value;

            TimeSpan ts = bugunTarihi - arizaTarihi;

            lblgirilengun.Text = "Arıza Başlangıç Tarihi : " + arizaTarihi.ToShortDateString();
            lblkalan.Text = "Toplam Arıza Süresi : " + ts.Days.ToString();


        }


        private void lblkalan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }




        void ToplamUretilen()
        {
           
            /*     
                 baglanti.Open();
                 komut = new SqlCommand("Select t1.Deger, t2.Acıklama from Eklee t1, Acıklaa t2 ", baglanti);
                 SqlDataReader read = komut.ExecuteReader();
                 while (read.Read())
                 {
                     ComboBoxItem item = new ComboBoxItem();
                     item.Text = read[0].ToString();
                     comboBox1.Items.Add(item);
                 }

                 baglanti.Close();
     */


            /*
                baglanti.Open();
                
                SqlCommand doldur = new SqlCommand("Select t1.Deger, t2.Acıklama from Eklee t1, Acıklaa t2 ", baglanti);
                SqlDataReader data = doldur.ExecuteReader();
                while (data.Read())
                {


               
                txtAcıklama.Text = data["Acıklama"].ToString();

                


            }
            
            baglanti.Close();

*/
        }

        private void button2_Click(object sender, EventArgs e)

        {
            string sql1 = "insert into Acıklaa(Deger) values('" + comboBox1.Text + "')";

            komut = new SqlCommand();

            Crud.ESG(sql1, komut);

            SqlCommand VeriKaydet = new SqlCommand("insert into Acıklaa(Acıklama) values(@Acıklama)", baglanti);




            string sql2 = " Update Acıklaa Set Acıklama='" + txtAcıklama.Text + "' Where Deger='" + comboBox1.Text + "'";
            komut = new SqlCommand();
            Crud.ESG(sql2, komut);

            VeriKaydet.Parameters.AddWithValue("@Acıklama", txtAcıklama.Text);
            baglanti.Open();
            VeriKaydet.ExecuteNonQuery();

            baglanti.Close();
            ToplamUretilen();
            MessageBox.Show("Veri Eklendi");

            /*
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into Acıklaa values(@Acıklama)", baglanti);
            ekle.Parameters.AddWithValue("@Acıklama", txtAcıklama.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            CBBolum();
            comboBox1.Text = "";

*/





            /*
            SqlCommand VeriKaydet = new SqlCommand("insert into Acıklaa(Acıklama) values(@Acıklama)", baglanti);




            string sql = " Update Acıklaa Set Ariza='" + txtAcıklama.Text + "' Where Deger='" + txtID.Text + "'";
            komut = new SqlCommand();

            VeriKaydet.Parameters.AddWithValue("@Acıklama", txtAcıklama.Text);
            baglanti.Open();
            VeriKaydet.ExecuteNonQuery();

            baglanti.Close();
            ToplamUretilen();
            MessageBox.Show("Veri Eklendi");
*/
            /*
            string sorgu = "INSERT INTO Acıklaa(Deger, Acıklama) VALUES(@Deger, @Acıklama)";
           
            komut = new SqlCommand(sorgu, baglanti);
            string Deger = ((ComboBoxItem)comboBox1.SelectedItem).value.ToString();
            komut.Parameters.AddWithValue("@Deger", Deger);

            komut.Parameters.AddWithValue("@Acıklama", txtAcıklama.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplamUretilen();
            MessageBox.Show("Veri Eklendi");
            */
            /*
            SqlCommand VeriKaydet = new SqlCommand("insert into Acıklaa(Acıklama) values(@Acıklama)", baglanti);




              string sql = " Update Acıklaa Set Ariza='" + txtAcıklama.Text + "' Where Deger='" + txtID.Text + "'";
              komut = new SqlCommand();

              VeriKaydet.Parameters.AddWithValue("@Acıklama", txtAcıklama.Text);
              baglanti.Open();
              VeriKaydet.ExecuteNonQuery();

              baglanti.Close();
              ToplamUretilen();
              MessageBox.Show("Veri Eklendi");

    */

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAcıklama_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtAcıklama_TextChanged(object sender, EventArgs e)
        {



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Acıklaa where Deger like'" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAcıklama.Text = read["Acıklama"].ToString();

            }

            baglanti.Close();
          

            /*
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "Deger";
            comboBox1.ValueMember = "ID";
            txtID.Text = txtID.Text.ToString();

*/
            /*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Acıklaa where ID like'" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAcıklama.Text = read["Acıklama"].ToString();

            }

            baglanti.Close();
            */
            /*
            string sorgu = "select *from Acıklaa a where a.Deger = @deger";
            komut = new SqlCommand(sorgu, baglanti);
            

            komut.Parameters.AddWithValue("@Deger",);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAcıklama.Text = read["Acıklama"].ToString();
            }
            baglanti.Close();

*/

            /*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Acıklaa where ID like'" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAcıklama.Text = read["Acıklama"].ToString();

            }

            baglanti.Close();
        }
        */
        }

        /*
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Acıklaa where ID=@ID", baglanti);
            sil.Parameters.AddWithValue("@ID", txtID.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            CBBolum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update Acıklaa set Acıklama=@Acıklama where ID=@ID", baglanti);
            komut1.Parameters.AddWithValue("@ID", txtID.Text);
            komut1.Parameters.AddWithValue("@bolumad", comboBox1.Text);

            komut1.ExecuteNonQuery();

            baglanti.Close();
            CBBolum();
        }
        */
    }
}
    

