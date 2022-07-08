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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= elektronik.accdb");
            try
            {

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO alim (TcKimlik,stokKodu,AlisTarih,Fiyat) VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox3.Text + "');", baglanti);
                komut.ExecuteNonQuery();
                comboBox2.Items.Clear();
                MessageBox.Show("Başarıyla Gerçekleştirildi");

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            MessageBox.Show("Ana Sayfaya Yönlendiriliyorsunuz...");
            frm2.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                comboBox1.Items.Clear();
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= elektronik.accdb");
                OleDbCommand komut = new OleDbCommand();
                OleDbCommand komut2 = new OleDbCommand();
                OleDbCommand komut3 = new OleDbCommand();
                komut.Connection = baglanti;
                komut2.Connection = baglanti;
                komut3.Connection = baglanti;
                baglanti.Open();
                komut.CommandText = "Select stokkodu from elektro Where Durum='Uygun'";
                komut2.CommandText = "Select TcKimlik from musteri ";
                komut3.CommandText = "Select Fiyat from elektro";
                OleDbDataReader oku2 = komut2.ExecuteReader();
                OleDbDataReader oku = komut.ExecuteReader();
                OleDbDataReader oku3 = komut3.ExecuteReader();

                while (oku.Read())
                {
                    comboBox2.Items.Add(oku[0].ToString());
                }
                while (oku2.Read())
                {
                    comboBox1.Items.Add(oku2[0].ToString());
                }
                while (oku3.Read())
                {
                    comboBox3.Items.Add(oku3[0].ToString());
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
