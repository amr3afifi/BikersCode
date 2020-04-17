namespace DBapplication
{
    partial class SearchEmployeeBySalary
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Less = new System.Windows.Forms.RadioButton();
            this.Equal = new System.Windows.Forms.RadioButton();
            this.Greater = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 244);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salary";
            // 
            // Less
            // 
            this.Less.AutoSize = true;
            this.Less.Location = new System.Drawing.Point(181, 15);
            this.Less.Name = "Less";
            this.Less.Size = new System.Drawing.Size(75, 17);
            this.Less.TabIndex = 9;
            this.Less.TabStop = true;
            this.Less.Text = "Less Than";
            this.Less.UseVisualStyleBackColor = true;
            this.Less.CheckedChanged += new System.EventHandler(this.Less_CheckedChanged);
            // 
            // Equal
            // 
            this.Equal.AutoSize = true;
            this.Equal.Location = new System.Drawing.Point(272, 16);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(68, 17);
            this.Equal.TabIndex = 10;
            this.Equal.TabStop = true;
            this.Equal.Text = "Equal To";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.CheckedChanged += new System.EventHandler(this.Equal_CheckedChanged);
            // 
            // Greater
            // 
            this.Greater.AutoSize = true;
            this.Greater.Location = new System.Drawing.Point(363, 16);
            this.Greater.Name = "Greater";
            this.Greater.Size = new System.Drawing.Size(88, 17);
            this.Greater.TabIndex = 11;
            this.Greater.TabStop = true;
            this.Greater.Text = "Greater Than";
            this.Greater.UseVisualStyleBackColor = true;
            this.Greater.CheckedChanged += new System.EventHandler(this.Greater_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 13;
            // 
            // SearchEmployeeBySalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 325);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Greater);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Less);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "SearchEmployeeBySalary";
            this.Text = "SearchEmployeeBySalary";
            this.Load += new System.EventHandler(this.SearchEmployeeBySalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Less;
        private System.Windows.Forms.RadioButton Equal;
        private System.Windows.Forms.RadioButton Greater;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}