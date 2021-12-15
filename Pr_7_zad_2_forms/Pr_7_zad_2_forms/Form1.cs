using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_7_zad_2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int buf = 0;
            string str = "";
            string[] s;
            str = textBox1.Text;
            s = str.Split();
            for (int i = 0; i < s.Length; i++)
            {
                buf = s[i].Length;
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (char.IsUpper(s[i][j]))
                    {
                        for (int z = 0; z < s[i].Length; z++)
                        {
                            if (s[i][z] != ',')
                                    if (s[i][z] != '.')
                                               textBox2.Text+=Convert.ToString(s[i][z]);
                        }
                        Console.WriteLine();
                    }
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " "; textBox1.Text = "";
        }
    }
}
