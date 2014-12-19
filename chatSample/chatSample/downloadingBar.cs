using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatSample
{
    public partial class downloadingBar : Form
    {
        public downloadingBar()
        {
            InitializeComponent();
        }

        private void downloadingBar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar_();
        }
        public void fn_prbar_()
        {
            progressBar1.Increment(1);
            label1.Text = "Connecting to server_" + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Server has been connected");
                this.Close();
                timer1.Stop();

            }
        }
    }
}
