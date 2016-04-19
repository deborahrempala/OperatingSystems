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
    public partial class addSpecialOrders : Form
    {
        byte[] bytes = new byte[1024];

        int port = 5011;

        Socket Mysender = new Socket(AddressFamily.InterNetwork,
  SocketType.Stream, ProtocolType.Tcp);
        public addSpecialOrders()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

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
            byte[] type = Encoding.ASCII.GetBytes("S");

            int functionType = Mysender.Send(type);
            int commaSent10 = Mysender.Send(comma);

            byte[] firstName = Encoding.ASCII.GetBytes(textBox6.Text);
            int NameSent = Mysender.Send(firstName);
            int commaSent = Mysender.Send(comma);
            byte[] lastName = Encoding.ASCII.GetBytes(textBox5.Text);
            int lastNameSent = Mysender.Send(lastName);
            int commaSent1 = Mysender.Send(comma);
            byte[] itemName = Encoding.ASCII.GetBytes(textBox4.Text);
            int itemNameSent = Mysender.Send(itemName);
            int commaSent2 = Mysender.Send(comma);
            byte[] itemType = Encoding.ASCII.GetBytes(comboBox2.Text);
            int TypeSent = Mysender.Send(itemType);
            int commaSent3 = Mysender.Send(comma);
            byte[] Cost = Encoding.ASCII.GetBytes(textBox7.Text);
            int CostSent = Mysender.Send(Cost);
            int commaSent4 = Mysender.Send(comma);
            byte[] Quanity = Encoding.ASCII.GetBytes(textBox8.Text);
            int QuanitySent = Mysender.Send(Quanity);
            int commaSent5 = Mysender.Send(comma);
            if (checkBox1.Checked)
            {
                byte[] Restricted1 = Encoding.ASCII.GetBytes(checkBox1.Text);
                int RestrictedSent1 = Mysender.Send(Restricted1);
                int commaSent6 = Mysender.Send(comma);
            }
                if (checkBox2.Checked)
                {

                    byte[] Restricted2 = Encoding.ASCII.GetBytes(checkBox2.Text);
                    int RestrictedSent2 = Mysender.Send(Restricted2);
                    int commaSent7 = Mysender.Send(comma);
                }
                if (checkBox3.Checked)
                {
                    byte[] Muggle1 = Encoding.ASCII.GetBytes(checkBox3.Text);
                    int MuggleSent1 = Mysender.Send(Muggle1);
                    int commaSent8 = Mysender.Send(comma);
                }

                if (checkBox4.Checked)
                {
                    byte[] Muggle2 = Encoding.ASCII.GetBytes(checkBox4.Text);
                    int MuggleSent2 = Mysender.Send(Muggle2);
                    int commaSent9 = Mysender.Send(comma);
                }

                // Send the data through the socket.

                // Receive the response from the remote device.
                Mysender.Shutdown(SocketShutdown.Both);
                Mysender.Close();
                this.Close();
            }
        }
    }

