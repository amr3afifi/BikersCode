namespace DBapplication
{
    partial class Accessories
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
            this.SuspendLayout();
            // 
            // addbutton2
            // 
            this.addbutton2.Location = new System.Drawing.Point(226, 59);
            this.addbutton2.Name = "addbutton2";
            this.addbutton2.Size = new System.Drawing.Size(75, 23);
            this.addbutton2.TabIndex = 12;
            this.addbutton2.Text = "Add";
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
            this.comboBox1.Location = new System.Drawing.Point(58, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // typetextBox
            // 
            this.typetextBox.Location = new System.Drawing.Point(58, 39);
            this.typetextBox.Name = "typetextBox";
            this.typetextBox.Size = new System.Drawing.Size(100, 20);
            this.typetextBox.TabIndex = 8;
            this.typetextBox.TextChanged += new System.EventHandler(this.typetextBox_TextChanged);
            // 
            // Accessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 185);
            this.Controls.Add(this.addbutton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typetextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Accessories";
            this.Text = "Accesssories";
            this.Load += new System.EventHandler(this.Accessories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typetextBox;
    }
}