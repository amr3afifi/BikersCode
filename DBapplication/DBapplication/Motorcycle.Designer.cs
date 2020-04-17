namespace DBapplication
{
    partial class Motorcycle
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
            this.addbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.colortextBox = new System.Windows.Forms.TextBox();
            this.cctextBox = new System.Windows.Forms.TextBox();
            this.yeartextBox = new System.Windows.Forms.TextBox();
            this.typetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(208, 113);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 18;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "CC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Year";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(15, 76);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 14;
            this.type.Text = "Type";
            // 
            // colortextBox
            // 
            this.colortextBox.Location = new System.Drawing.Point(67, 196);
            this.colortextBox.Name = "colortextBox";
            this.colortextBox.Size = new System.Drawing.Size(100, 20);
            this.colortextBox.TabIndex = 13;
            // 
            // cctextBox
            // 
            this.cctextBox.Location = new System.Drawing.Point(67, 156);
            this.cctextBox.Name = "cctextBox";
            this.cctextBox.Size = new System.Drawing.Size(100, 20);
            this.cctextBox.TabIndex = 12;
            // 
            // yeartextBox
            // 
            this.yeartextBox.Location = new System.Drawing.Point(67, 115);
            this.yeartextBox.Name = "yeartextBox";
            this.yeartextBox.Size = new System.Drawing.Size(100, 20);
            this.yeartextBox.TabIndex = 11;
            // 
            // typetextBox
            // 
            this.typetextBox.Location = new System.Drawing.Point(67, 74);
            this.typetextBox.Name = "typetextBox";
            this.typetextBox.Size = new System.Drawing.Size(100, 20);
            this.typetextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Model";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Motorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.colortextBox);
            this.Controls.Add(this.cctextBox);
            this.Controls.Add(this.yeartextBox);
            this.Controls.Add(this.typetextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Motorcycle";
            this.Text = "Motocycle";
            this.Load += new System.EventHandler(this.Motorcycle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox colortextBox;
        private System.Windows.Forms.TextBox cctextBox;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.TextBox typetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

    }
}