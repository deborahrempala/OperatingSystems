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
namespace StoreManager
{
    public partial class deleteSpecialOrders : Form
    {
        byte[] bytes = new byte[1024];

        int port = 6035;
        Socket Mysender = new Socket(AddressFamily.InterNetwork,
  SocketType.Stream, ProtocolType.Tcp);
        public deleteSpecialOrders()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IPHostEntry ipHostInfo = Dns.GetHostEntry("tacosalad.lssu.edu");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            Mysender.Connect(remoteEP);

            Console.WriteLine("Socket connected to {0}",
                Mysender.RemoteEndPoint.ToString());
            
            // Encode the data string into a byte array.
         
            byte[] lastName = Encoding.ASCII.GetBytes(textBox1.Text);
            int flastnameSent = Mysender.Send(lastName);





            // Receive the response from the remote device.
            Mysender.Shutdown(SocketShutdown.Both);
            Mysender.Close();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            IPHostEntry ipHostInfo = Dns.GetHostEntry("tacosalad.lssu.edu");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            Mysender.Connect(remoteEP);

            Console.WriteLine("Socket connected to {0}",
                Mysender.RemoteEndPoint.ToString());
            byte[] comma = Encoding.ASCII.GetBytes(",");
            // Encode the data string into a byte array.
            byte[] type = Encoding.ASCII.GetBytes("D");
            int functionType = Mysender.Send(type);
            byte[] lastName = Encoding.ASCII.GetBytes(textBox1.Text);
            int flastnameSent = Mysender.Send(lastName);





            // Receive the response from the remote device.
            Mysender.Shutdown(SocketShutdown.Both);
            Mysender.Close();
            this.Close();
        }
    }
}
