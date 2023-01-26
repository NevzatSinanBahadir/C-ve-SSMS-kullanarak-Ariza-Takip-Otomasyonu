using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;


namespace SqlServer_Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Yenile()
        {
            dataGridView1.DataSource = Crud.List("Select * from Eklee");

        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)

        {
            // TODO: Bu kod satırı 'tTADataSet1.Eklee' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ekleeTableAdapter.Fill(this.tTADataSet1.Eklee);


            Yenile();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        void Temizle()
        {
            foreach (Control item in this.panel2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }

            }
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Crud.List("Select * from Eklee Where Deger like '%" + textAra.Text + "%'");
        }

        SqlCommand komut;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "insert into Eklee(Deger,Ariza,Tarih) values('" + txtID.Text + "','" + textAriza.Text + "',@Tarih)";
            string sql1 = "insert into Acıklaa(Deger) values('" + txtID.Text + "')";

            komut = new SqlCommand();

            Crud.ESG(sql1, komut);

            komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = dateTimePicker1.Value;
            Crud.ESG(sql, komut);
            Yenile();
            Temizle();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          

            Form2 f2 = new Form2();

            f2.comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.txtID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.textAriza.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            f2.ShowDialog();
            

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sql = " Update Eklee Set Ariza='" + textAriza.Text + "',Tarih = @Tarih Where Deger='" + txtID.Text + "'";
            komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = dateTimePicker1.Value;
            Crud.ESG(sql, komut);
            Yenile();
            Temizle();




        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Kayıt Silinsin Mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string sql = " Delete from Eklee Where Deger='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                komut = new SqlCommand();

                Crud.ESG(sql, komut);
                Yenile();
                Temizle();
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridView1[i, j].Value;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {




        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textAriza.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


            DateTime bugunTarihi = DateTime.Now;




            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {


                if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Tarih"].Value.ToString()) > bugunTarihi.AddDays(-4))
                {
                    dataGridView1.Rows[i].Cells["Tarih"].Style.BackColor = Color.Green;
                    dataGridView1.Rows[i].Cells["Tarih"].Style.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["Tarih"].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells["Tarih"].Style.ForeColor = Color.White;
                }
            }





            /*
            string dateString = @"27/07/2022";
            DateTime date2 = Convert.ToDateTime(dateString,
            System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
            DateTime b = dateTimePicker1.Value;
            DateTime a = DateTime.Now;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {


                if (b > a.AddDays(-3))
                {
                    dataGridView1.Rows[i].Cells["Tarih"].Style.BackColor = Color.Green;
                    dataGridView1.Rows[i].Cells["Tarih"].Style.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["Tarih"].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells["Tarih"].Style.ForeColor = Color.White;
                }
            }
            */

        }










        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*
            TimeSpan fark;
            fark = DateTime.Now - DateTime.Parse(dateTimePicker1.Text);
            string sonuc = fark.TotalDays.ToString();

    

            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount -1;
            chart1.Series["Arıza Sayısı"].Points.AddXY("Arıza Sayısı", kayitsayisi);
            
            MessageBox.Show("Toplam Arıza Sayısı:" + kayitsayisi.ToString());
            */
        }

        private void textAriza_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount - 1;
            chart1.Series["Arıza Sayısı"].Points.AddXY("Arıza Sayısı", kayitsayisi);

            MessageBox.Show("Toplam Arıza Sayısı:" + kayitsayisi.ToString());
        }
    }


}