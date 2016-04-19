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
    public partial class modifyItem : Form
    {
        byte[] bytes = new byte[1024];
        int port = 6061;
        Socket Mysender = new Socket(AddressFamily.InterNetwork,
        SocketType.Stream, ProtocolType.Tcp);
        public modifyItem()
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
            byte[] comma = Encoding.ASCII.GetBytes(",");
            // Encode the data string into a byte array.
            byte[] type = Encoding.ASCII.GetBytes("I");

            int functionType = Mysender.Send(type);
            int commaSent10 = Mysender.Send(comma);
            byte[] itemName = Encoding.ASCII.GetBytes(textBox1.Text);
            int NameSent = Mysender.Send(itemName);
            int commaSent = Mysender.Send(comma);
            byte[] itemType = Encoding.ASCII.GetBytes(comboBox1.Text);
            int TypeSent = Mysender.Send(itemType);
            int commaSent1 = Mysender.Send(comma);
            if (checkBox1.Checked)
            {
                byte[] Restricted1 = Encoding.ASCII.GetBytes(checkBox1.Text);
                int RestrictedSent1 = Mysender.Send(Restricted1);
                int commaSent2 = Mysender.Send(comma);
            }
            if (checkBox2.Checked)
            {

                byte[] Restricted2 = Encoding.ASCII.GetBytes(checkBox2.Text);
                int RestrictedSent2 = Mysender.Send(Restricted2);
                int commaSent3 = Mysender.Send(comma);
            }

            byte[] Cost = Encoding.ASCII.GetBytes(textBox2.Text);
            int CostSent = Mysender.Send(Cost);
            int commaSent4 = Mysender.Send(comma);

            byte[] Quanity = Encoding.ASCII.GetBytes(textBox3.Text);
            int QuanitySent = Mysender.Send(Quanity);
            int commaSent5 = Mysender.Send(comma);

            if (checkBox3.Checked)
            {
                byte[] Muggle1 = Encoding.ASCII.GetBytes(checkBox3.Text);
                int MuggleSent1 = Mysender.Send(Muggle1);
                int commaSent7 = Mysender.Send(comma);
            }

            if (checkBox4.Checked)
            {
                byte[] Muggle2 = Encoding.ASCII.GetBytes(checkBox4.Text);
                int MuggleSent2 = Mysender.Send(Muggle2);
                int commaSent6 = Mysender.Send(comma);
            }
            // Send the data through the socket.

            // Receive the response from the remote device.
            Mysender.Shutdown(SocketShutdown.Both);
            Mysender.Close();
            this.Close();

        }
    }
}

