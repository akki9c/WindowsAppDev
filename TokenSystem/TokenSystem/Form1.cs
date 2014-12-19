using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Speech.Synthesis;

namespace TokenSystem
{
    public partial class Form1 : Form
    {
        int g = 1;
        int m = 0;
        int i = 0;
        int k = 0;
        Queue lst = new Queue();
        SpeechSynthesizer rec = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int l = 0;
            m = 1;
            if (lst.Count > 0)
            {
            listBox1.Items.Add(lst.Peek());
            listBox4.Items.RemoveAt(l);
            lst.Dequeue();
            label1.Text = "Token Number" +" "+ g++ + " goes to window" +" "+ m;
            label3.Text = lst.Count.ToString() + " " + "customer's in queue";
            rec.SpeakAsync(label1.Text);
            }
            else
            {
                MessageBox.Show("There is no more customer");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = 0;
            m = 2;
            if (lst.Count > 0)
            {
            listBox2.Items.Add(lst.Peek());
            listBox4.Items.RemoveAt(l);
            lst.Dequeue();
            label1.Text = "Token Number" +" "+ g++ + " goes to window" +" "+ m;
            label3.Text = lst.Count.ToString() +" " + "customer's in queue";
            rec.SpeakAsync(label1.Text);
            }
            else
            {
                MessageBox.Show("There is no more customer");
            } 
            
            }

        private void button3_Click(object sender, EventArgs e)
        {
            int l = 0;
            m = 3;
            if (lst.Count > 0)
            {
                listBox3.Items.Add(lst.Peek());
                listBox4.Items.RemoveAt(l);
                lst.Dequeue();
                label1.Text = "Token Number" +" "+ g++ + " goes to window" +" "+ m;
                label3.Text = lst.Count.ToString() + " " + "customer's in queue";

                rec.SpeakAsync(label1.Text);
            }
            else
            {
                MessageBox.Show("There is no more customer");
            }
            
            }

        
        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add((i+= 1).ToString());
            
            lst.Enqueue(k += 1);
            label3.Text = lst.Count.ToString() + " " + "customer's in queue";
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
    }
}
