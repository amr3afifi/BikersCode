namespace DBapplication
{
    partial class updateaccessory
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
            this.addbutton2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typetextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addbutton2
            // 
            this.addbutton2.Location = new System.Drawing.Point(330, 184);
            this.addbutton2.Name = "addbutton2";
            this.addbutton2.Size = new System.Drawing.Size(75, 23);
            this.addbutton2.TabIndex = 17;
            this.addbutton2.Text = "Update";
            this.addbutton2.UseVisualStyleBackColor = true;
            this.addbutton2.Click += new System.EventHandler(this.addbutton2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XLarge"});
            this.comboBox1.Location = new System.Drawing.Point(69, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type";
            // 
            // typetextBox
            // 
            this.typetextBox.Location = new System.Drawing.Point(69, 132);
            this.typetextBox.Name = "typetextBox";
            this.typetextBox.Size = new System.Drawing.Size(100, 20);
            this.typetextBox.TabIndex = 13;
            this.typetextBox.TextChanged += new System.EventHandler(this.typetextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 28);
            this.button2.TabIndex = 48;
            this.button2.Text = "Add new Supplier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Motorcycle",
            "Sparepart",
            "Accessory"});
            this.comboBox2.Location = new System.Drawing.Point(284, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "supplier_name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Price";
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(72, 97);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(100, 20);
            this.pricetextbox.TabIndex = 44;
            this.pricetextbox.TextChanged += new System.EventHandler(this.pricetextbox_TextChanged);
            // 
            // updateaccessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.addbutton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typetextBox);
            this.Name = "updateaccessory";
            this.Text = "updateaccessory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typetextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pricetextbox;
    }
}