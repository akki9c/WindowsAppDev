using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }
 

        private double num1;

        private double num2;

        private string cal;

       private bool inputstatus = true;

       private void button17_Click_17(object sender, EventArgs e)

        {


            if (inputstatus)

            {

                 if (textBox2.Text.Length >= 1)

                {

                    textBox2.Text = button17.Text;

                }

            }
        }

 
        private void button2_Click_2(object sender, EventArgs e)

        {

            if (inputstatus)

            {

                textBox2.Text += button2.Text;

            }

            else

            {

                textBox2.Text = button2.Text;

                inputstatus = true;

            }

 

        }

 
        private void button3_Click_3(object sender, EventArgs e)

        {

            if (inputstatus)

            {

                textBox2.Text += button3.Text;

            }

            else

            {

                textBox2.Text = button3.Text;

                inputstatus = true;
           }

 

        }

 

        private void button13_Click_13(object sender, EventArgs e)

        {

            if (inputstatus)

            {

                textBox2.Text += button13.Text;

            }
            else
            {
                textBox2.Text = button13.Text;
                inputstatus = true;
            }
 
        }
 
        private void button5_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox2.Text += button5.Text;
            }
            else
            {
                textBox2.Text = button5.Text;

                inputstatus = true;

            }

 
        }
 
        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox2.Text += button6.Text;

            }
            else
            {
                textBox2.Text = button6.Text;
                inputstatus = true;
            }
 
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox2.Text += button1.Text;
            }
            else
            {
                textBox2.Text = button1.Text;
                inputstatus = true;
            }
        }
 
        private void button12_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox2.Text += button12.Text;
            }
            else
            {
                textBox2.Text = button12.Text;
                inputstatus = true;
            }
 
        }
 
        private void button9_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox2.Text += button9.Text;
            }
            else
            {
                textBox2.Text = button9.Text;
                inputstatus = true;

            }
 

        }

 

        private void button10_Click(object sender, EventArgs e)

        {

            if (inputstatus)
            {

                textBox2.Text += button10.Text;

            }

            else

            {

                textBox2.Text = button10.Text;
                inputstatus = true;
            }
 
 
        }
 

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox2.Text);
                result();
                cal = "+";
            }
 
        }
 
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox2.Text);
                result();
                cal = "-";
            }
        }
 
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox2.Text);
                result();
                cal = "*";
            }
 
        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox2.Text);

                result();

                cal = "/";

            }

 

        }

        private void button8_Click(object sender, EventArgs e)

       {

 

            result();

            cal = string.Empty;

 

        }

        private void button11_Click(object sender, EventArgs e)

        {

            textBox2.Text = string.Empty;

            num1 = 0;
            num2 = 0;

          cal = string.Empty;

       }

 

        private void result()

        {

            num2 = System.Double.Parse(textBox2.Text);

            switch (cal)

            {

                case "+":

                    num1 = num1 + num2;

                    break;

                case "-":

                    num1 = num1 - num2;

                  break;

                case "*":

                    num1 = num1 * num2;

                    break;

                case "/":

                    num1 = num1 / num2;
                   break;

         }

            textBox2.Text = num1.ToString();

            inputstatus = false;

        }
 

      private void copyToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBox2.Copy();

        }

 

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBox2.Paste();

        }

 

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBox2.Cut();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

    }

}
