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
    public partial class Form3 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=elektronik.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader dr;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Select * from kullaniciMudur where kadi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'";
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Form5 frm2 = new Form5();
                MessageBox.Show("Giriş Yapılıyor Lütfen Bekleyiniz...");
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı veya Şifrenizi Kontrol Ediniz !");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            MessageBox.Show("Ana Sayfaya Yönlendiriliyorsunuz...");
            frm2.Show();
            this.Hide();
        }
    }
}
