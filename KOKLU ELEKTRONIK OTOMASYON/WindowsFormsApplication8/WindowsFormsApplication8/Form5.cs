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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= elektronik.accdb");
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                baglanti.Open();
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "")
                {
                    komut.CommandText = "INSERT INTO elektro(stokKodu,Marka,UrunAdi,Model,Guc,Fiyat,Durum) VALUES('" + TextBox1.Text + "' , '" + TextBox2.Text + "','" + TextBox3.Text + "',' " + TextBox4.Text + "','" + TextBox5.Text + "','" + textBox8.Text + "','" + "uygun" + "')";

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Elektronik Malzeme Alımı Başarıyla Gerçekleştirildi");
                    string b = "Select *from elektro";
                    OleDbDataAdapter d = new OleDbDataAdapter(b, baglanti);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    DataSet f = new DataSet();
                    f.Tables.Add(t);
                    bindingSource1.DataSource = f;
                    bindingSource1.DataMember = f.Tables[0].TableName;
                    DataGridView1.DataSource = bindingSource1;
                    baglanti.Close();
                    TextBox1.Clear();
                    TextBox2.Clear();
                    TextBox3.Clear();
                    TextBox4.Clear();
                    TextBox5.Clear();

                }
                else
                {
                    MessageBox.Show("Boş alan Bırakmayın!");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 fr1 = new Form8();
            this.Visible = false;
            fr1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= elektronik.accdb");
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                baglanti.Open();
                komut.CommandText = "DELETE FROM elektro WHERE stokKodu='" + TextBox6.Text.Trim().ToString() + "' AND Marka='" + TextBox7.Text.Trim().ToString() + "'";
                komut.ExecuteNonQuery();
                MessageBox.Show("Elektronik Malzeme Satıldı");
                string b = "Select *from elektro";
                OleDbDataAdapter d = new OleDbDataAdapter(b, baglanti);
                DataTable t = new DataTable();
                d.Fill(t);
                DataSet f = new DataSet();
                f.Tables.Add(t);
                bindingSource1.DataSource = f;
                bindingSource1.DataMember = f.Tables[0].TableName;
                DataGridView1.DataSource = bindingSource1;
                baglanti.Close();
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
    }
}
