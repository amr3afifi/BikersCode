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
    public partial class Accessories : Form
    {
        Controller controllerobj = new Controller();

        public Accessories()
        {
            InitializeComponent();
        }

        private void Accessories_Load(object sender, EventArgs e)
        {

        }

        private void addbutton2_Click(object sender, EventArgs e)
        {
            int result = controllerobj.InsertAcc(typetextBox.Text, comboBox1.Text);
            if (result <= 0)
                MessageBox.Show("Accessory additon failed");

            else
                MessageBox.Show("Accessory added successfuly");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typetextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
