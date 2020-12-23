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
    public partial class Form2 : Form
    {
        public string one;
        public string two;
        public string three;
        public string four;
        public string five;
        public string six;
        public string seven;
        public string eight;
        public string nine;
        public string ten;
        public string eleven;
        public string twelve;
        public string thirteen;
        public int summ = 0;
        public bool nul = false;

        public Form2()
        {
            InitializeComponent();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            one = comboBox1.Text;
            two = comboBox2.Text;
            three = comboBox3.Text;
            four = comboBox4.Text;
            five = textBox1.Text;
            six = textBox2.Text;
            seven = comboBox5.Text;
            eight = comboBox6.Text;
            nine = comboBox7.Text;
            ten = comboBox8.Text;
            eleven = comboBox9.Text;
            twelve = comboBox10.Text;
            thirteen = comboBox11.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    summ += 200;
                    break;
                case 1:
                    summ += 250;
                    break;
                case 2:
                    summ += 150;
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    summ += 200;
                    break;
                case 1:
                    summ += 150;
                    break;
                case 2:
                    summ += 50;
                    break;
                case 3:
                    summ += 10;
                    break;
            }
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    summ += 0;
                    nul = true;
                    break;
                case 1:
                    summ += 150;
                    break;
                case 2:
                    summ += 50;
                    break;
                case 3:
                    summ += 150;
                    break;
                case 4:
                    summ += 100;
                    break;
                case 5:
                    summ += 10;
                    break;
                case 6:
                    summ += 50;
                    break;
                case 7:
                    summ += 0;
                    nul = true;
                    break;
            }
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    summ += 100;
                    break;
                case 1:
                    summ += 150;
                    break;
                case 2:
                    summ += 350;
                    break;
                case 3:
                    summ += 300;
                    break;
            }
            switch (comboBox8.SelectedIndex)
            {
                case 0:
                    summ += 0;
                    break;
                case 1:
                    summ += 50;
                    break;
                case 2:
                    summ += 100;
                    break;
                case 3:
                    summ += 200;
                    break;
            }
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    summ += 30;
                    
                    break;
                case 1:
                    summ += 50;
                    break;
                case 2:
                    summ += 120;
                    break;
                case 3:
                    summ += 150;
                    break;
                case 4:
                    summ += 200;
                    break;
                case 5:
                    summ += 300;
                    break;
                
            }
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    summ += 200;
                    break;
                case 1:
                    summ += 0;
                    break;
            }
            switch (comboBox10.SelectedIndex)
            {
                case 0:
                    summ += 200;
                    break;
                case 1:
                    summ += 0;
                    break;
            }
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    summ += 10;

                    break;
                case 1:
                    summ += 10;
                    break;
                case 2:
                    summ += 50;
                    break;
                case 3:
                    summ += 150;
                    break;
            }
            switch (comboBox9.SelectedIndex)
            {
                case 0:
                    summ = 0;
                    nul = true;
                    break;
                case 1:
                    summ += 50;
                    break;
                case 2:
                    summ += 80;
                    break;
                case 3:
                    summ += 300;
                    break;
                case 4:
                    summ += 50;
                    break;
            }
            switch (comboBox11.SelectedIndex)
            {
                case 0:
                    summ += 50;
                    break;
                case 1:
                    summ = 80;
                    break;
                case 2:
                    summ += 150;
                    break;
                case 3:
                    summ += 200;
                    break;
                case 4:
                    summ += 60;
                    break;
            }
            Form4 fm1 = new Form4();
            if (nul)
            {
                fm1.textBox1.Text = "Нажаль один з вибраних пунктів критично суперечить правилам нашого кредитування";
                this.Hide();
                fm1.ShowDialog();
                this.Close();
            }
            else
            {

                if (summ < 600)
                {
                    fm1.textBox1.Text = "Нажаль оцінка вашої кредитоспроможності занадто низька для погодження позики";
                    this.Hide();
                    fm1.ShowDialog();
                    this.Close();
                }
                else {
                    Form3 fm = new Form3();
                    fm.nul = nul;
                    fm.summ = summ;
                    this.Hide();
                    fm.ShowDialog();
                    this.Hide();
                }
            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboBox4, "При данній відповіді вам буде відмовлено в кредитуванні");
            }
            else
            {
                if (comboBox4.SelectedIndex == 7)
                {
                    errorProvider1.SetError(comboBox4, "При данній відповіді вам буде відмовлено в кредитуванні");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboBox9, "При данній відповіді вам буде відмовлено в кредитуванні");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
