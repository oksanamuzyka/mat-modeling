using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketa
{
    public partial class Form1 : Form
    {
        public string name;
        public string surname;
        public string surname1;
        public string telephone;
        public string email;
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
        string writePath = ".//1.txt";


        public Form1()
        {
            
            
            InitializeComponent();
            
            label1.Font = new Font("Times New Roman", 12, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 12, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 12, label2.Font.Style);
            label4.Font = new Font("Times New Roman", 12, label2.Font.Style);
            label5.Font = new Font("Times New Roman", 12, label2.Font.Style);
            label6.Font = new Font("Times New Roman", 12, label2.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            openFileDialog1.Filter = "Picture files(*.jpg)|*.jpg|Picture files(*.png)|*.png|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (openFileDialog1.FileName == "C:\\Users\\Ksusha\\Pictures\\1.jpg")
            {
                pictureBox1.Image = anketa.Properties.Resources._1;
                pictureBox1.Visible = true;
                errorProvider1.Clear();
            }
            else
            {
                if (openFileDialog1.FileName == "C:\\Users\\Ksusha\\Pictures\\2.jpg")
                {
                    pictureBox1.Image = anketa.Properties.Resources._2;
                    pictureBox1.Visible = true;
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(button1, "Завантажене вами зображення не схоже на потрібний нам документ");
                    pictureBox1.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty && textBox5.Text != String.Empty && pictureBox1.Visible!=false)
            {
                if (Regex.IsMatch(textBox1.Text, @"^[А-Я][а-я]*$")&& Regex.IsMatch(textBox3.Text, @"^[А-Я][а-я]*$")&& Regex.IsMatch(textBox2.Text, @"^[А-Я][а-я]*$"))
                {
                    surname = textBox1.Text;
                    name = textBox2.Text;
                    surname1 = textBox3.Text;
                    email = textBox4.Text;
                    telephone = textBox5.Text;
                    Form2 fm = new Form2();
                    this.Hide();
                    fm.ShowDialog();
                    one = fm.one;
                    two = fm.two;
                    three = fm.three;
                    four = fm.four;
                    five = fm.five;
                    six = fm.six;
                    seven = fm.seven;
                    eight = fm.eight;
                    nine = fm.nine;
                    ten = fm.ten;
                    eleven = fm.eleven;
                    twelve = fm.twelve;
                    thirteen = fm.thirteen;
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(surname + " " + name + " " + surname1);
                        sw.WriteLine(email + " " + telephone+" Вікова категорія " + thirteen);
                        sw.WriteLine("Сімейне положення: "+one + "\nКількість дітей: " + two + "\nСфера діяльності: " + four);
                        sw.WriteLine("Кваліфікація: "+three + "\nПрофесія: " + five + "\nОрганізація: " + six);
                        sw.WriteLine("Стаж роботи: "+ten + "\nДохід: " + nine + "\nАктиви: " + eight);
                        sw.WriteLine("Житло: "+seven + "\nАвтомобіль: " + twelve + "\nКредитна історія: " + eleven);
                        sw.WriteLine();
                        sw.WriteLine();
                    }
                    this.Close();
                    errorProvider1.Clear();
                }
                else
                {
                    if (!Regex.IsMatch(textBox1.Text, @"^[А-Я][а-я]*$"))
                        errorProvider1.SetError(textBox1, "Некоректне введення");
                    else
                    {
                        errorProvider1.Clear();
                        if (!Regex.IsMatch(textBox2.Text, @"^[А-Я][а-я]*$"))
                            errorProvider1.SetError(textBox2, "Некоректне введення");
                        else
                        {
                            errorProvider1.Clear();
                            if (!Regex.IsMatch(textBox3.Text, @"^[А-Я][а-я]*$"))
                                errorProvider1.SetError(textBox3, "Некоректне введення");
                            else
                                errorProvider1.Clear();
                        }
                    }

                }
                
            }
            else
            {
                if (pictureBox1.Visible != true)
                {
                    errorProvider1.SetError(button1, "Завантажте скан свого паспорту");
                }
                else
                    errorProvider1.SetError(button3, "Заповніть всі поля даної форми");
            }
        }
    }
}
