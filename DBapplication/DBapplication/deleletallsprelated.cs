using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class deleletallsprelated : Form
    {
        Controller controllerObj;
        string pid;
        public deleletallsprelated(string d)
        {
            InitializeComponent();
            controllerObj = new Controller();
            pid = d;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.deletebeltomotor(Convert.ToInt32(pid)); ;
            if (result == 0)
            {
                MessageBox.Show("Spareparts Not deleted");
            }
            else
            {
                MessageBox.Show("Spareparts deleted successfully!");
                controllerObj.Deleteproduct(Convert.ToInt32(pid));
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleletallsprelated_Load(object sender, EventArgs e)
        {

        }
    }
}
