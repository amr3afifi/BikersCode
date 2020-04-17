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
    public partial class AddProduct : Form
    {
        Controller controllerObj = new Controller();

        public AddProduct()
        {
            InitializeComponent();
            DataTable dt;
             dt = controllerObj.SelectSupplier();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
            
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(pricetextbox.Text) ||  comboBox1.Text=="")
            {
                MessageBox.Show("Make sure to fill Type, supplier_name, Price");
                return;
            }


            
            string p  = pricetextbox.Text;
            double result;

            if (!Double.TryParse(p, out  result))
            {
                MessageBox.Show("Please enter a proper price");
                return;
            }


            float price = (float)Convert.ToDouble(p);


            controllerObj.AddProduct(comboBox2.Text, price);
            string pid=Convert.ToString(controllerObj.GetProductID());

            DataTable dt = controllerObj.SelectBranches();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string branch = dt.Rows[i][0].ToString();
                controllerObj.InsertProductinBranchHas(pid, branch);
                controllerObj.InsertProductinBranchSold(pid, branch);
            }


            if (comboBox1.Text == "Motorcycle")
            {
              
                Motorcycle m = new Motorcycle();
                m.Show();

            }
           
                else if (comboBox1.Text == "Sparepart")
                {
                    
                    new SpareParts().Show();


                }
               
                    else if (comboBox1.Text == "Accessory")
                    {
                       
                        new Accessories().Show();

                    }
                    
                          

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pricetextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                pricetextbox.Text = pricetextbox.Text.Remove(pricetextbox.Text.Length - 1);
                pricetextbox.Text = String.Empty;
            }
        }

        private void suppnametextbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertSupplier iis=new InsertSupplier();
            iis.FormClosed += new FormClosedEventHandler(iis_FormClosed);
            iis.Show();    
        }

        private void iis_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt;
            dt = controllerObj.SelectSupplier();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
        }

    }
}
