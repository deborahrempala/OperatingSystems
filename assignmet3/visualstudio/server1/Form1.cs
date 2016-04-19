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
namespace server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            int port = 5011;
            IPHostEntry ipHostInfo = Dns.GetHostEntry("tacosalad.lssu.edu");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            Socket Mysender = new Socket(AddressFamily.InterNetwork,
      SocketType.Stream, ProtocolType.Tcp);


            Mysender.Connect(remoteEP);

            Console.WriteLine("Socket connected to {0}",
                Mysender.RemoteEndPoint.ToString());

            // Encode the data string into a byte array.
            byte[] msg = Encoding.ASCII.GetBytes(textBox1.Text);

            // Send the data through the socket.
            int bytesSent = Mysender.Send(msg);

            // Receive the response from the remote device.
            int bytesRec = Mysender.Receive(bytes);

            string stuff = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            label1.Text = stuff;
            // Release the socket.
            Mysender.Shutdown(SocketShutdown.Both);
            Mysender.Close();
        }
    }
}
