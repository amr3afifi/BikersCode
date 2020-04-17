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
    public partial class DeleteProduct : Form
    {
        Controller controllerObj;
        public DeleteProduct()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }
        public DeleteProduct(string i)
        {
            InitializeComponent();
            controllerObj = new Controller();
            textBox1.Text= i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            { MessageBox.Show("Please enter id of product to perform the deletion"); }
            else
            {
                if (controllerObj.GetMotorCycleInSpareparts(textBox1.Text) != 0)
                {
                    deleletallsprelated d = new deleletallsprelated(textBox1.Text);
                    d.Show();

                }

                int result = controllerObj.Deleteproduct(Convert.ToInt32(textBox1.Text)); ;
                if (result == 0)
                {
                    MessageBox.Show("No rows are deleted,Make sure to search for product_id first");
                }
                else
                {
                    MessageBox.Show("The row is deleted successfully!");
                }

            }
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
