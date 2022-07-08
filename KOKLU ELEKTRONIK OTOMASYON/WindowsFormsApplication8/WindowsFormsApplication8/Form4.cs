using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= elektronik.accdb");
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                baglanti.Open();
                if (textBox1.TextLength == 11 && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    komut.CommandText = "INSERT INTO musteri(TcKimlik,Ad,Soyad,Cinsiyet,Telefon,Mail,Sehir) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "',' " + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi");
                    string a = "Provider=Microsoft.Ace.OleDb.12.0;data source=elektronik.accdb";
                    string b = "Select * From musteri";
                    OleDbConnection c = new OleDbConnection(a);
                    OleDbDataAdapter d = new OleDbDataAdapter(b, c);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    DataSet f = new DataSet();
                    f.Tables.Add(t);
                    bindingSource1.DataSource = f;
                    bindingSource1.DataMember = f.Tables[0].TableName;
                    dataGridView1.DataSource = bindingSource1;
                    c.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();

                }
                else
                {
                    MessageBox.Show("Eksik ya da hatalı doldurdunuz!");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= elektronik.accdb");
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                baglanti.Open();
                komut.CommandText = "DELETE FROM musteri WHERE TcKimlik='" + textBox7.Text + "' ";
                komut.ExecuteNonQuery();
                textBox7.Text = "";
                textBox8.Text = "";
                MessageBox.Show("Kayıt Silindi");
                string b = "Select *from musteri";
                OleDbDataAdapter d = new OleDbDataAdapter(b, baglanti);
                DataTable t = new DataTable();
                d.Fill(t);
                DataSet f = new DataSet();
                f.Tables.Add(t);
                bindingSource1.DataSource = f;
                bindingSource1.DataMember = f.Tables[0].TableName;
                dataGridView1.DataSource = bindingSource1;
                baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
