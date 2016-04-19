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
    public partial class Form1 : Form
    {
        mainMenu menu;
        public Form1()
        {
            InitializeComponent();
            menu = new mainMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.ShowDialog();
         
          }
        }
    }


