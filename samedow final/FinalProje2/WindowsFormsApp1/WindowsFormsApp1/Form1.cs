using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Double TLpara = 0;
        double USD = 0.02564;
        double EUR = 0.02257;
        double GBP = 0.01894;
        double CHF = 0.02106;
        double JPY = 3.65583;
        double CAD = 0.03522;
        double NOK = 0.18543;
        double AUD = 0.03948;
        double CNY = 0.18543;
        double SEK = 0.24446;
        double sonuc = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TLpara = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz." , "Hata!", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir para birimi seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((comboBox1.Text != "USD(Amerikan Doları)") && (comboBox1.Text != "EUR (Euro)") && (comboBox1.Text != "GBP (İngiliz Sterlini)") && (comboBox1.Text != "CHF (İsviçre Frangı)") && (comboBox1.Text != "JPY (Japon Yeni") && (comboBox1.Text == "CAD (Kanada Doları)") && (comboBox1.Text == "NOK (Norveç Kronu)") && (comboBox1.Text == "AUD (Avusturya Doları)") &&   (comboBox1.Text == "CNY(Çin Yuanı)") && (comboBox1.Text == "SEK (İsveç Kronu)"))
            {
                MessageBox.Show("Lütfen geçerli bir para birimi seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.Text == "USD (Amerikan Doları)")
            {
                sonuc = TLpara * USD;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "EUR (Euro)")
            {
                sonuc = TLpara * EUR;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "CHF (İsviçre Frangı)")
            {
                sonuc = TLpara * CHF;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "JPY (Japon Yeni)")
            {
                sonuc = TLpara * JPY;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "CAD (Kanada Doları)")
            {
                sonuc = TLpara * CAD;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "AUD (Avustralya Doları)")
            {
                sonuc = TLpara * AUD;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "CNY (Çin Yuanı)")
            {
                sonuc = TLpara * CNY;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "SEK (İsveç Kronu)")
            {
                sonuc = TLpara * SEK;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "NOK (Norveç Kronu)")
            {
                sonuc = TLpara * NOK;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            else if (comboBox1.Text == "GBP (İngiliz Sterlini)")
            {
                sonuc = TLpara * GBP;
                sonuc.ToString();
                label3.Text = sonuc.ToString() + " " + comboBox1.Text;
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
