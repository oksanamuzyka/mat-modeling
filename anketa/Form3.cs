using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketa
{
    public partial class Form3 : Form
    {
        public bool nul;
        public int summ;
        public Form3()
        {
            InitializeComponent();
           
            label2.Font = new Font("Times New Roman", 12, label2.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();

            if (summ > 600 && summ < 1000)
            {
                if (Convert.ToInt32(textBox2.Text) > 15000)
                {
                    fm.textBox1.Text = "Нажаль банк не може видати бажану вами суму кредиту. Для пожодження зверніться у відділення банку.";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    fm.textBox1.Text = "Кредитування на вказану вами суму можливе, для отримання позики зверніться до відділення банку";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
            }
            if (summ > 1000 && summ < 1500)
            {
                if (Convert.ToInt32(textBox2.Text) > 25000)
                {
                    fm.textBox1.Text = "Нажаль банк не може видати бажану вами суму кредиту. Для пожодження зверніться у відділення банку.";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    fm.textBox1.Text = "Кредитування на вказану вами суму можливе, для отримання позики зверніться до відділення банку";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
            }
            if (summ > 1500 && summ < 2000)
            {
                if (Convert.ToInt32(textBox2.Text) > 35000)
                {
                    fm.textBox1.Text = "Нажаль банк не може видати бажану вами суму кредиту. Для пожодження зверніться у відділення банку.";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    fm.textBox1.Text = "Кредитування на вказану вами суму можливе, для отримання позики зверніться до відділення банку";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
            }
            if (summ > 2000)
            {
                if (Convert.ToInt32(textBox2.Text) > 50000)
                {
                    fm.textBox1.Text = "Нажаль банк не може видати бажану вами суму кредиту. Для пожодження зверніться у відділення банку.";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    fm.textBox1.Text = "Кредитування на вказану вами суму можливе, для отримання позики зверніться до відділення банку";
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
