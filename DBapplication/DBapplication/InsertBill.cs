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
    public partial class InsertBill : Form
    {
        User U;
        bool canaddproduct = false;
        Controller controllerObj;
        public InsertBill(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectBranches();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Name";
            }
            else
            {
                comboBox1.Text = U.BranchName;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" ) //validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                int r = controllerObj.InsertBill(textBox1.Text,comboBox1.Text,date);
                if (r > 0)
                {
                    MessageBox.Show("Bill created successfully");
                    canaddproduct = true;
                }
                else
                    MessageBox.Show("Error creating bill");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canaddproduct)
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") //validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else if (controllerObj.GetProductAvailableQuantity(textBox2.Text)<Convert.ToInt32(textBox3.Text))
                {
                    MessageBox.Show("Insufficient quantity");
                    textBox3.Text = "";
                }
                else
                {
                    int bn = controllerObj.GetBillNumber();
                    int r=controllerObj.UpdateProductQuantityOnBill(bn, textBox2.Text, textBox3.Text);
                    if (r > 0)
                        MessageBox.Show("Product already on bill, quantity updated");
                    else
                    {

                        r = controllerObj.InsertBillInvolvesProduct(bn, textBox2.Text, textBox3.Text);
                        if (r > 0)
                        {
                            MessageBox.Show("Product added successfully");
                            
                            controllerObj.UpdateQuantitySoldinBranch(textBox3.Text,textBox2.Text,comboBox1.Text);
                            controllerObj.UpdateQuantityHasinBranch(textBox3.Text, textBox2.Text, comboBox1.Text);
                            controllerObj.UpdateProductTotalStock(textBox3.Text, textBox2.Text);
                            double price = controllerObj.GetProductPrice(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                            controllerObj.UpdateCustomerPoints(price.ToString(), textBox1.Text);
                            textBox2.Text = "";
                            textBox3.Text = "";
                        }


                        else
                            MessageBox.Show("Error adding product");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, create bill first");
            }
        }

        private void InsertBill_Load(object sender, EventArgs e)
        {

        }
    }
}
