using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;





namespace DBapplication
{
    public partial class Product : Form
    {
        private Controller controllerObj;
        User U;
        public Product(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
            if (U.Priv == Privileges.CustServiceDepartmentEmployee || U.Priv == Privileges.CustServiceDepartmentManager)
            {
                idtextbox.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Product_Load(object sender, EventArgs e)
        {


        }

        private void counttextbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void idtextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idtextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                idtextbox.Text = idtextbox.Text.Remove(idtextbox.Text.Length - 1);
                idtextbox.Text = String.Empty;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable mt = controllerObj.showallmotor();
            dataGridView1.DataSource = mt;
            dataGridView1.Refresh();

            DataTable sp = controllerObj.showallsp();
            dataGridView2.DataSource = sp;
            dataGridView2.Refresh();

            DataTable ac = controllerObj.showallacc();
            dataGridView3.DataSource = ac;
            dataGridView3.Refresh();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataTable dt = controllerObj.Searchproduct(idtextbox.Text);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            { MessageBox.Show("Please enter type of product to perform the search"); }
            else
            {
                DataTable mt = controllerObj.Searchmotor(textBox3.Text);
                dataGridView1.DataSource = mt;
                dataGridView1.Refresh();

                DataTable sp = controllerObj.Searchspare(textBox3.Text);
                dataGridView2.DataSource = sp;
                dataGridView2.Refresh();

                DataTable ac = controllerObj.Searchacc(textBox3.Text);
                dataGridView3.DataSource = ac;
                dataGridView3.Refresh();


                if (mt == null && sp == null && ac == null)
                    MessageBox.Show("Product does not exist");
            }
        }




        private void countbutton_Click(object sender, EventArgs e)
        {
            counttextbox.Text = controllerObj.Countmotor().ToString();
            textBox4.Text = controllerObj.Countsp().ToString();
            textBox5.Text = controllerObj.Countacc().ToString();
        }

        private void suppnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = String.Empty;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = String.Empty;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Make sure to fill the ID");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a number to inc");
                    return;
                }
                else
                    controllerObj.incby(Convert.ToInt32(idtextbox.Text), Convert.ToInt32(textBox1.Text));
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Make sure to fill the ID");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter a number to dec");
                    return;
                }
                else
                    controllerObj.decby(Convert.ToInt32(idtextbox.Text), Convert.ToInt32(textBox2.Text));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable mt = controllerObj.showoutallmotor();
            dataGridView1.DataSource = mt;
            dataGridView1.Refresh();

            DataTable sp = controllerObj.showoutallsp();
            dataGridView2.DataSource = sp;
            dataGridView2.Refresh();

            DataTable ac = controllerObj.showoutallacc();
            dataGridView3.DataSource = ac;
            dataGridView3.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Make sure to fill the ID");
                return;
            }
            else
            {
                int result = controllerObj.deletebeltomotor(Convert.ToInt32(idtextbox.Text)); ;
                if (result == 0)
                {
                    MessageBox.Show("Spareparts Not deleted");
                }
                else
                {
                    MessageBox.Show("Spareparts deleted successfully!");
                }
             
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if(controllerObj.ifproductismotor(idtextbox.Text)!=0)
                {
                new updatemotor(idtextbox.Text).Show();
                return;
                }
           if (controllerObj.ifproductisacc(idtextbox.Text) != 0)
                {
                new updateaccessory(idtextbox.Text).Show();
                return;
            }
           if( controllerObj.ifproductissp(idtextbox.Text) != 0)
                {
                new updatesparepart(idtextbox.Text).Show();
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new DeleteProduct(idtextbox.Text).Show();
            
        }
    }
}


