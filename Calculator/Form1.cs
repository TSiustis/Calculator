using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math = System.Math;
namespace Calculator
{
    public partial class Form1 : Form
    {
        String op;
        String total1,total2 , current;
         double result;

        public Form1()
        {
            InitializeComponent();
            button18.Text = "\u00B1";
            button19.Text = "\u00F7";
            button15.Text = "\u2715";
            button14.Text = "\u2212";
            button1.Text = "\u003D";
            button23.Text = "\u0025";
            button22.Text = "\u221A";
            button21.Text = "x"+"\u00B2";
            button20.Text = "1/x";
            label1.Text = "";
            button13.Text = "+";
            label2.Text = "";
            this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            current.TrimEnd(current[current.Length - 1]);
            string s = label2.Text;
            string s1 = label2.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }
            if (s1.Length > 1)
            {
                s1 = s.Substring(0, s.Length - 1);
            }
            else
            {
                s1 = "0";
            }
            label1.Text = s;
            label2.Text = s;
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current  += button5.Text;
            label1.Text += current;
            label2.Text +=  button5.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if(current[0]!='-')
            current = '-' + current;
            else
            {
                current = current.Substring(1, current.Length - 1);
            }
            label1.Text += current;
            label2.Text += " " + "(negate) "+ current  ;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current += button10.Text;
            label1.Text += current;
            label2.Text += button10.Text;

        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current += button8.Text;
            label1.Text += current;
            label2.Text +=  button8.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            current += button7.Text;
            label1.Text += current;
            label2.Text += button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            current += button9.Text;
            label1.Text += current;
            label2.Text +=  button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            current += button11.Text;
            label1.Text += current;
            label2.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current += button12.Text;
            label1.Text += current;
            label2.Text += button12.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            

            current += button6.Text;
            label1.Text += current;
            label2.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total2 = current;
            double num1, num2;
            double.TryParse(total1, out num1);
            double.TryParse(total2, out num2);
            switch (op)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = (num2 / 100) * num1;
                    break;
                case "sqrt":
                    result = Math.Sqrt(num2);
                    break;

            }

            label1.Text = result.ToString();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            total1 = current;
            label1.Text = button14.Text;
            op = "-";
            current = "";
            label2.Text += " " + op;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            total1 = current;
            label1.Text = button15.Text;
            op = "*";
            current = "";
             
            label2.Text += " " + op;
        }

        private void button19_Click(object sender, EventArgs e)
        {
             total1= current ;
            label1.Text = button19.Text;
            op = "/";
            current = "";

            label2.Text += " " + op;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            current = "";
            total1 = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            total1 = current;
            label1.Text = button13.Text;
            op = "+";
            current = "";

            label2.Text += " " + op;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                button17.PerformClick();
            }
            if (e.KeyChar == '1')
            {
                e.Handled = true;
                button8.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                e.Handled = true;
                button7.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                e.Handled = true;
                button9.PerformClick();
            }
            if (e.KeyChar == '4')
            {
                e.Handled = true;
                button12.PerformClick();
            }
            if (e.KeyChar == '5')
            {
                e.Handled = true;
                button11.PerformClick();
            }
             if (e.KeyChar == '6')
            {
                e.Handled = true;
                button10.PerformClick();
            }
            if (e.KeyChar == '7')
            {
                e.Handled = true;
                button5.PerformClick();
            }
            if (e.KeyChar == '8')
            {
                e.Handled = true;
                button6.PerformClick();
            }
            if (e.KeyChar == '9')
            {
                e.Handled = true;
                button4.PerformClick();
            }
            if (e.KeyChar == '*')
            {
                e.Handled = true;
                button15.PerformClick();
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
                button14.PerformClick();
            }

            if (e.KeyChar == '+')
            {
                e.Handled = true;
                button13.PerformClick();
            }
            if (e.KeyChar == '/')
            {
                e.Handled = true;
                button19.PerformClick();
            }
            if (e.KeyChar == '=')
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            total1 = current;
            label1.Text = button13.Text;
            op = "%";
            current = "";

            label2.Text += " " + op;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current += button17.Text;
            label1.Text += current;
            label2.Text +=  button17.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            total1 = current;
            double num;
            double.TryParse(total1, out num);
            Math.Sqrt(num);
            
            label1.Text = num.ToString();
            label2.Text += " " + current + "sqrt" ;
            current = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double num;
            total1 = current;
            label1.Text = button13.Text;

            double.TryParse(total1, out num);
            current = "";
            label1.Text = (num * num).ToString();
            label2.Text += " " + label1.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double num;
            total1 = current;
            label1.Text = button13.Text;

            double.TryParse(total1, out num);
            current = "";
            label1.Text = (1/num).ToString();
            label2.Text += " " + label1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current += button4.Text;
            label1.Text += current;
            label2.Text += button4.Text;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            current = "";
        }
    }
}
