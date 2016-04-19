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
    public partial class itemsMenu : Form
    {
        addItem add;
        modifyItem modify;
        deleteItem delete;
     
        public itemsMenu()
 
        {
            InitializeComponent();
            add = new addItem();
            modify = new modifyItem();
            delete = new deleteItem();
        

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tacosalad.lssu.edu/~drempala/csci434/term/viewitems.cgi");
        }
    }
}
