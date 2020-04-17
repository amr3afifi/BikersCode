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
    public partial class DeleteSupplier : Form
    {
        Controller controllerObj;
        public DeleteSupplier()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //validation part
            {
                MessageBox.Show("Please, insert supplier_name");
            }
            else
            {

                int r = controllerObj.DeleteSupplier(textBox1.Text);
                if (r > 0)
                {
                    MessageBox.Show("Supplier deleted successfully");
                    textBox1.Text = "";
                }
                else
                    MessageBox.Show("Error deleting supplier");
            }
        }
    }
}
