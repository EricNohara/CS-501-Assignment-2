namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textBox1.Location = new System.Drawing.Point(215, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 67);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(215, 121);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 23);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(296, 121);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 23);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(377, 121);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(215, 150);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 23);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(296, 150);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 23);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(458, 121);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.OpBtn_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(539, 121);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.OpBtn_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(377, 150);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 23);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(458, 150);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 23);
            this.subtract.TabIndex = 9;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.OpBtn_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(539, 150);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.OpBtn_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(215, 179);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 23);
            this.seven.TabIndex = 11;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(296, 179);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 23);
            this.eight.TabIndex = 12;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(377, 179);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 23);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(458, 179);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(156, 23);
            this.clear.TabIndex = 14;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(215, 208);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(156, 23);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(377, 208);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 23);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.DecimalBtn_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(458, 208);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(156, 23);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.six);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
    }
}

