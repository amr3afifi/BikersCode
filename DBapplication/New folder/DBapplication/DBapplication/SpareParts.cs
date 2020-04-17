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
     

    public partial class SpareParts : Form
    {
        Controller controllerobj = new Controller();

        public SpareParts()
        {
            InitializeComponent();
            DataTable dt;

            dt = controllerobj.GetMotorCycleId();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "motorcycle_id";
           
        }

        private void SpareParts_Load(object sender, EventArgs e)
        {

        }

        private void addbutton2_Click(object sender, EventArgs e)
        {
            string t = typetextBox.Text;
            string c = textBox1.Text;
            int i = Convert.ToInt32(comboBox1.Text);

            int result = controllerobj.InsertSparePart(t, c,i);
            if (result <= 0)
                MessageBox.Show("SparePart additon failed");

            else
                MessageBox.Show("SparePart added successfuly");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.GetMotorCycleByName(textBox2.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
