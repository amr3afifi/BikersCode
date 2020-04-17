namespace DBapplication
{
    partial class updatemotor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.colortextBox = new System.Windows.Forms.TextBox();
            this.cctextBox = new System.Windows.Forms.TextBox();
            this.yeartextBox = new System.Windows.Forms.TextBox();
            this.typetextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Model";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "CC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Year";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(21, 204);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 25;
            this.type.Text = "Type";
            // 
            // colortextBox
            // 
            this.colortextBox.Location = new System.Drawing.Point(73, 324);
            this.colortextBox.Name = "colortextBox";
            this.colortextBox.Size = new System.Drawing.Size(100, 20);
            this.colortextBox.TabIndex = 24;
            this.colortextBox.TextChanged += new System.EventHandler(this.colortextBox_TextChanged);
            // 
            // cctextBox
            // 
            this.cctextBox.Location = new System.Drawing.Point(73, 284);
            this.cctextBox.Name = "cctextBox";
            this.cctextBox.Size = new System.Drawing.Size(100, 20);
            this.cctextBox.TabIndex = 23;
            this.cctextBox.TextChanged += new System.EventHandler(this.cctextBox_TextChanged);
            // 
            // yeartextBox
            // 
            this.yeartextBox.Location = new System.Drawing.Point(73, 243);
            this.yeartextBox.Name = "yeartextBox";
            this.yeartextBox.Size = new System.Drawing.Size(100, 20);
            this.yeartextBox.TabIndex = 22;
            this.yeartextBox.TextChanged += new System.EventHandler(this.yeartextBox_TextChanged);
            // 
            // typetextBox
            // 
            this.typetextBox.Location = new System.Drawing.Point(73, 202);
            this.typetextBox.Name = "typetextBox";
            this.typetextBox.Size = new System.Drawing.Size(100, 20);
            this.typetextBox.TabIndex = 21;
            this.typetextBox.TextChanged += new System.EventHandler(this.typetextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 28);
            this.button2.TabIndex = 43;
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
            this.comboBox2.Location = new System.Drawing.Point(285, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 42;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "supplier_name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Price";
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(73, 113);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(100, 20);
            this.pricetextbox.TabIndex = 39;
            this.pricetextbox.TextChanged += new System.EventHandler(this.pricetextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatemotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.colortextBox);
            this.Controls.Add(this.cctextBox);
            this.Controls.Add(this.yeartextBox);
            this.Controls.Add(this.typetextBox);
            this.Name = "updatemotor";
            this.Text = "updatemotor";
            this.Load += new System.EventHandler(this.updatemotor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox colortextBox;
        private System.Windows.Forms.TextBox cctextBox;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.TextBox typetextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Button button1;
    }
}