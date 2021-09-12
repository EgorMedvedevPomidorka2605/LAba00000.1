using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAba0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string L = textBox1.Text;   
            string V1 = textBox2.Text;
            string t = textBox3.Text;
            double L_1 =1;
            double V1_1=1;
            double t_1=1;
            double result;
            

            try
            {
                L_1 = Convert.ToDouble(L);
                V1_1 = Convert.ToDouble(V1);
                t_1 = Convert.ToDouble(t);
                    result = L_1/(t_1 - L_1 / V1_1);
                    string result_1 = Convert.ToString(result);
                    textBox4.Text = result_1;
            }
            catch (Exception Error)
            {
                if (L_1 <= 0 || V1_1 <= 0 || t_1 <= 0)
                {
                    textBox4.Text = "Введены неверные параметры ";
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "Введены неверные параметры ";


            }

        }

        private void Н_Click(object sender, EventArgs e)
        {

        }
    }
}
