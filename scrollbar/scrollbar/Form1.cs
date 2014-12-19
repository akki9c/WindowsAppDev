using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            textBox2.Text = vScrollBar1.Value.ToString();
            textBox3.Text = vScrollBar2.Value.ToString();
            textBox4.Text = vScrollBar3.Value.ToString();
            label4.ForeColor = textBox1.BackColor;
            label5.ForeColor = Color.FromArgb(vScrollBar1.Value, 0, 0);    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            textBox2.Text = vScrollBar1.Value.ToString();
            textBox3.Text = vScrollBar2.Value.ToString();
            textBox4.Text = vScrollBar3.Value.ToString();
            label4.ForeColor = textBox1.BackColor;
            label6.ForeColor = Color.FromArgb(0, vScrollBar2.Value,0);    
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            textBox2.Text = vScrollBar1.Value.ToString();
            textBox3.Text = vScrollBar2.Value.ToString();
            textBox4.Text = vScrollBar3.Value.ToString();
            label4.ForeColor = textBox1.BackColor;
            label7.ForeColor = Color.FromArgb(0, 0, vScrollBar3.Value);   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(0, 0, 0);
           /* vScrollBar1.Value = int.Parse(textBox2.Text);
            Int32 a = vScrollBar1.Value;
            b = string.Format("{0:x}", a);
            textBox2.Text = b;*/
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            label5.ForeColor = Color.FromArgb(vScrollBar1.Value, 0, 0);   
       
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.FromArgb(0, 0, 0);
            //vScrollBar2.Value = int.Parse(textBox3.Text);
           // Int32 decValue = vScrollBar2.Value;
            //textBox3.Text = string.Format("{0:x}", decValue);
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            label6.ForeColor = Color.FromArgb(0,vScrollBar2.Value, 0);   
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.FromArgb(0,0,0);
            //vScrollBar3.Value = int.Parse(textBox4.Text);
            //Int32 decValue = vScrollBar3.Value;
           // textBox4.Text=string.Format("{0:x}", decValue);
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            label7.ForeColor = Color.FromArgb(0,0,vScrollBar3.Value); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10);
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            BackColor = Color.BurlyWood;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BackColor = Color.Transparent;
            //BackColor = Color.Blue;
           
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.BurlyWood;
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.MediumVioletRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b,c,d;
            Int32 a = vScrollBar1.Value;
            b = string.Format("{0:x}", a);
            textBox2.Text = b;
            
            
            Int32 f = vScrollBar2.Value;
            c = string.Format("{0:x}", f);
            textBox3.Text = c;
            
            
            Int32 g = vScrollBar3.Value;
            d = string.Format("{0:x}", g);
            textBox4.Text = d;
        }
    }
}
