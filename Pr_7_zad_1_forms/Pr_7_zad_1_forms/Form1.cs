using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Pr_7_zad_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = " ";
            line = Convert.ToString(textBox1.Text);
            char x;
            char y;
            x = char.Parse(textBox2.Text);
            y = char.Parse(textBox3.Text);

            int countX = line.Where(a => a == x).Count();
            int countY = line.Where(a => a == y).Count();
            if (line.Contains((char)x) || line.Contains((char)y))
            {
                if (countX > countY)
                textBox4.Text= Convert.ToString("Больше всего встречается="+x);
            else if (countY > countX)
                textBox4.Text = Convert.ToString("Больше всего встречается=" + y);
            else
                textBox4.Text = Convert.ToString("Они встречаются одинаково");
            }
            else
                textBox4.Text = Convert.ToString("Таких символов нет");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
        }
    }
}
