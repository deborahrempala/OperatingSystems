using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class mainMenu : Form
    {
        itemsMenu imenu;
        employeesMenu emenu;
        specialordersMenu spmenu;
        public mainMenu()
        {
          
            InitializeComponent();
            imenu = new itemsMenu();
            emenu = new employeesMenu();
            spmenu = new specialordersMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emenu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spmenu.ShowDialog();
        }
    }
}
