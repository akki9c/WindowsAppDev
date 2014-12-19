using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = new int[] {
                (int)ContentAlignment.TopCenter,
                (int)ContentAlignment.MiddleRight,
                (int)ContentAlignment.BottomCenter,
                (int)ContentAlignment.MiddleLeft
        };
            int i;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = DateTime.Now.ToLongTimeString();
            label1.ImageAlign = (ContentAlignment)a[i];
            i = i + 1;
            if (i == 4)
                i = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
