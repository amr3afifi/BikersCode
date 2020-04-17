namespace DBapplication
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.counttextbox = new System.Windows.Forms.TextBox();
            this.countbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showallbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(106, 68);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(204, 20);
            this.idtextbox.TabIndex = 0;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "product_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 496);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // counttextbox
            // 
            this.counttextbox.Location = new System.Drawing.Point(223, 467);
            this.counttextbox.Name = "counttextbox";
            this.counttextbox.Size = new System.Drawing.Size(100, 20);
            this.counttextbox.TabIndex = 10;
            this.counttextbox.TextChanged += new System.EventHandler(this.counttextbox_TextChanged);
            // 
            // countbutton
            // 
            this.countbutton.Location = new System.Drawing.Point(14, 467);
            this.countbutton.Name = "countbutton";
            this.countbutton.Size = new System.Drawing.Size(75, 23);
            this.countbutton.TabIndex = 11;
            this.countbutton.Text = "Count";
            this.countbutton.UseVisualStyleBackColor = true;
            this.countbutton.Click += new System.EventHandler(this.countbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 197);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showallbutton
            // 
            this.showallbutton.Location = new System.Drawing.Point(794, 195);
            this.showallbutton.Name = "showallbutton";
            this.showallbutton.Size = new System.Drawing.Size(179, 23);
            this.showallbutton.TabIndex = 15;
            this.showallbutton.Text = "ShowALLProducts";
            this.showallbutton.UseVisualStyleBackColor = true;
            this.showallbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(611, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(67, 26);
            this.searchbutton.TabIndex = 16;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Increment Stock By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Decrement Stock By";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(338, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(308, 197);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(665, 255);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(308, 197);
            this.dataGridView3.TabIndex = 23;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Motorcycles";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "SpareParts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Accessories";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 20);
            this.textBox3.TabIndex = 27;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(352, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Write Type (if Accessory or SparePart) or Model (if Motorcycle) of Product";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Inc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Dec";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(546, 467);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 31;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(877, 467);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(794, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "ShowProducts OutofStock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(370, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 26);
            this.button4.TabIndex = 34;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 26);
            this.button5.TabIndex = 35;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 496);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.showallbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.countbutton);
            this.Controls.Add(this.counttextbox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtextbox);
            this.Name = "Product";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox counttextbox;
        private System.Windows.Forms.Button countbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showallbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

