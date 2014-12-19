using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Web.Services.Protocols;
using System.Diagnostics;
using System.IO;


namespace chatSample
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
            
        }

       
        

        
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string recievedMessage = aEncoding.GetString(receivedData);
                listMessage.Items.Add("Friend: " + recievedMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIp();
            GetIP();
           // textRemoteIp.Text = GetLocalIp();
            textLocalPort.Text = "80";
            textRemotePort.Text = "81";
            
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            //socket ke bind karela
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);
            //remote ip connect karela
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);
            //specific port ke sunela
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            new downloadingBar().Show();
            
        }


        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            //covert kare padi msg strint to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);
            //encoded mssg ke send kare padi
            sck.Send(sendingMessage);
            //listbox main add kre padi
            listMessage.Items.Add("Me: " + textMessage.Text);
            textMessage.Text = "";
        }
        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }


            return "127.0.0.1";
        }


        private void GetIP()
        {
            Process netUtility = new Process();

            netUtility.StartInfo.FileName = "net.exe";

            netUtility.StartInfo.CreateNoWindow = true;

            netUtility.StartInfo.Arguments = "view";

            netUtility.StartInfo.RedirectStandardOutput = true;

            netUtility.StartInfo.UseShellExecute = false;

            netUtility.StartInfo.RedirectStandardError = true;

            netUtility.Start();



            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);



            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {

                if (line.StartsWith("\\"))
                {

                    listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());

                }

            }

            streamReader.Close();
            netUtility.WaitForExit(1000);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GetIP();
        }
    }
}
