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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Font = new Font("Times New Roman", 11, textBox1.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
