using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace frmClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private IPEndPoint IP;
        private Socket client;

        private void Connect()
        {
            try
            {
                string hostname = Dns.GetHostName();
                IPHostEntry hostInfo = Dns.GetHostByName(hostname);//chi lay ipv4

                IP = new IPEndPoint(hostInfo.AddressList[0], 2000);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("error");
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        private void Closee()
        {
            client.Close();
        }

        private void Send()
        {
            try
            {
                byte[] data;
                if (txt_Message.Text != "")
                {
                    data = Serialize(txt_Message.Text);
                    addMessage(txt_Message.Text);
                    txt_Message.Text = "";
                    client.Send(data);
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[5000 * 1024];
                    client.Receive(data);
                    string text = (string)Deserialize(data);
                    addMessage(text);
                }
            }
            catch
            {
                MessageBox.Show("error");
                client.Close();
            }
        }

        private byte[] Serialize(object str)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, str);
            return ms.ToArray();
        }

        private object Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(ms);
        }

        private void addMessage(string str)
        {
            rtb_history.Text += str + "\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Closee();
            }
            catch { }
        }

        private void btn_Send_Click_1(object sender, EventArgs e)
        {
            Send();
        }
    }
}