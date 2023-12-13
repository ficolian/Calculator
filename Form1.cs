using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static double sum;
        public static string optrstring;
        public static string numbertext;
        public static bool optr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button plus
            if (optr)
            {
                optr = false;
                double txt1 = Convert.ToDouble(textBox4.Text);
                Calculate(txt1, optrstring);
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " +";
            }
            else
            {
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " +";
            }
            optrstring = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button times
            if (optr)
            {
                optr = false;
                double txt1 = Convert.ToDouble(textBox4.Text);
                if (sum == 0)
                    sum = 1;
                Calculate(txt1, optrstring);
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " *";
            }
            else
            {
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " *";
            }
            optrstring = "*";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //button minus
            if (optr)
            {
                //kalau sudah klik operator
                optr = false;
                double txt1 = Convert.ToDouble(textBox4.Text);
                Calculate(txt1, optrstring);
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " -";
            }
            else
            {
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " -";
            }

            optrstring = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button divide
            if (optr)
            {
                //kalau sudah klik operator
                optr = false;
                double txt1 = Convert.ToDouble(textBox4.Text);
                if (sum == 0)
                    sum = 1;
                Calculate(txt1, optrstring);
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " %";
            }
            else
            {
                textBox4.Text = sum.ToString();
                textBox1.Text = sum.ToString() + " %";
            }

            optrstring = "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //button number 1
            onClickNumber("1");
            textBox4.Text = numbertext;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            onClickNumber("2");
            textBox4.Text = numbertext;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            onClickNumber("3");
            textBox4.Text = numbertext;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            onClickNumber("4");
            textBox4.Text = numbertext;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            onClickNumber("5");
            textBox4.Text = numbertext;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            onClickNumber("6");
            textBox4.Text = numbertext;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            onClickNumber("7");
            textBox4.Text = numbertext;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            onClickNumber("8");
            textBox4.Text = numbertext;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //if (!optr)
            //{
            //    optr = true;
            //    numbertext = "";
            //}

            //numbertext = numbertext + "9";
            onClickNumber("9");
            textBox4.Text = numbertext;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //if (!optr)
            //{
            //    optr = true;
            //    numbertext = "";
            //}

            //numbertext = numbertext + "0";
            onClickNumber("0");
            textBox4.Text = numbertext;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numbertext = "";
            sum = 0;
            optr = false;
            textBox4.Text = "";
            textBox1.Text = "";
        }
        public static void Calculate (double number1, string optr)
        {
            switch (optr){
                case "+":
                    sum = sum + number1; 
                    break;
                case "-":
                    sum = sum - number1;
                    break;
                case "*":
                    sum = sum * number1;
                    break;
                case "/":
                    sum = sum / number1;
                    break;
                default:
                    sum = number1;
                    break;
            }     
        }
        public static void onClickNumber(string number)
        {
            if (!optr)
            {
                optr = true;
                numbertext = "";
            }

            numbertext = numbertext + number;
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                numbertext = textBox4.Text;
            }
            
        }

    }
}
