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
    public partial class addEmployees : Form
    {
        byte[] bytes = new byte[1024];

        int port = 5011;


        Socket Mysender = new Socket(AddressFamily.InterNetwork,
  SocketType.Stream, ProtocolType.Tcp);
        public addEmployees()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
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
            byte[] type = Encoding.ASCII.GetBytes("E");

            int functionType = Mysender.Send(type);
            int commaSent10 = Mysender.Send(comma);

            byte[] firstName = Encoding.ASCII.GetBytes(textBox1.Text);
            int NameSent = Mysender.Send(firstName);
            int commaSent = Mysender.Send(comma);
            byte[] lastName = Encoding.ASCII.GetBytes(textBox2.Text);
            int lastNameSent = Mysender.Send(lastName);
            int commaSent1 = Mysender.Send(comma);
            byte[] empType = Encoding.ASCII.GetBytes(comboBox1.Text);
            int TypeSent = Mysender.Send(empType);
            int commaSent2 = Mysender.Send(comma);
            byte[] Rate = Encoding.ASCII.GetBytes(textBox3.Text);
            int RateSent = Mysender.Send(Rate);
            // Send the data through the socket.








            // Receive the response from the remote device.
            Mysender.Shutdown(SocketShutdown.Both);
                Mysender.Close();
                this.Close();

            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
