namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUSCustomaryUnits = new RadioButton();
            btnMetricUnits = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbStatusOutput = new TextBox();
            btnCalculateBMI = new Button();
            btnResetForm = new Button();
            nudWeight = new NumericUpDown();
            nudHeightOne = new NumericUpDown();
            lbWeight = new Label();
            lbHeightUnitOne = new Label();
            nudHeightTwo = new NumericUpDown();
            lbHeightUnitTwo = new Label();
            tbBMIOutput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightTwo).BeginInit();
            SuspendLayout();
            // 
            // btnUSCustomaryUnits
            // 
            btnUSCustomaryUnits.AutoSize = true;
            btnUSCustomaryUnits.Location = new Point(266, 102);
            btnUSCustomaryUnits.Name = "btnUSCustomaryUnits";
            btnUSCustomaryUnits.Size = new Size(256, 36);
            btnUSCustomaryUnits.TabIndex = 0;
            btnUSCustomaryUnits.TabStop = true;
            btnUSCustomaryUnits.Text = "US Customary Units";
            btnUSCustomaryUnits.UseVisualStyleBackColor = true;
            btnUSCustomaryUnits.CheckedChanged += btnUSCustomaryUnits_CheckedChanged;
            // 
            // btnMetricUnits
            // 
            btnMetricUnits.AutoSize = true;
            btnMetricUnits.Location = new Point(590, 102);
            btnMetricUnits.Name = "btnMetricUnits";
            btnMetricUnits.Size = new Size(174, 36);
            btnMetricUnits.TabIndex = 1;
            btnMetricUnits.TabStop = true;
            btnMetricUnits.Text = "Metric Units";
            btnMetricUnits.UseVisualStyleBackColor = true;
            btnMetricUnits.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 215);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 2;
            label1.Text = "HEIGHT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 369);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 3;
            label2.Text = "WEIGHT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 659);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 4;
            label3.Text = "STATUS";
            // 
            // tbStatusOutput
            // 
            tbStatusOutput.Location = new Point(266, 727);
            tbStatusOutput.Name = "tbStatusOutput";
            tbStatusOutput.Size = new Size(679, 39);
            tbStatusOutput.TabIndex = 5;
            tbStatusOutput.TextChanged += tbStatusOutput_TextChanged;
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.Location = new Point(266, 531);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(679, 74);
            btnCalculateBMI.TabIndex = 6;
            btnCalculateBMI.Text = "Calculate BMI";
            btnCalculateBMI.UseVisualStyleBackColor = true;
            btnCalculateBMI.Click += btnCalculateBMI_Click;
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(826, 102);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(119, 52);
            btnResetForm.TabIndex = 7;
            btnResetForm.Text = "Reset";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += btnResetForm_Click;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(266, 442);
            nudWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(318, 39);
            nudWeight.TabIndex = 9;
            nudWeight.ValueChanged += nudWeight_ValueChanged;
            // 
            // nudHeightOne
            // 
            nudHeightOne.Location = new Point(266, 287);
            nudHeightOne.Name = "nudHeightOne";
            nudHeightOne.Size = new Size(162, 39);
            nudHeightOne.TabIndex = 10;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(651, 444);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(143, 32);
            lbWeight.TabIndex = 13;
            lbWeight.Text = "Pounds (lbs)";
            // 
            // lbHeightUnitOne
            // 
            lbHeightUnitOne.AutoSize = true;
            lbHeightUnitOne.Location = new Point(464, 289);
            lbHeightUnitOne.Name = "lbHeightUnitOne";
            lbHeightUnitOne.Size = new Size(97, 32);
            lbHeightUnitOne.TabIndex = 14;
            lbHeightUnitOne.Text = "Feet (ft)";
            // 
            // nudHeightTwo
            // 
            nudHeightTwo.Location = new Point(614, 289);
            nudHeightTwo.Name = "nudHeightTwo";
            nudHeightTwo.Size = new Size(162, 39);
            nudHeightTwo.TabIndex = 15;
            nudHeightTwo.ValueChanged += nudHeightTwo_ValueChanged;
            // 
            // lbHeightUnitTwo
            // 
            lbHeightUnitTwo.AutoSize = true;
            lbHeightUnitTwo.Location = new Point(810, 287);
            lbHeightUnitTwo.Name = "lbHeightUnitTwo";
            lbHeightUnitTwo.Size = new Size(123, 32);
            lbHeightUnitTwo.TabIndex = 16;
            lbHeightUnitTwo.Text = "Inches (in)";
            lbHeightUnitTwo.Click += label7_Click;
            // 
            // tbBMIOutput
            // 
            tbBMIOutput.Location = new Point(266, 807);
            tbBMIOutput.Name = "tbBMIOutput";
            tbBMIOutput.Size = new Size(679, 39);
            tbBMIOutput.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 984);
            Controls.Add(tbBMIOutput);
            Controls.Add(lbHeightUnitTwo);
            Controls.Add(nudHeightTwo);
            Controls.Add(lbHeightUnitOne);
            Controls.Add(lbWeight);
            Controls.Add(nudHeightOne);
            Controls.Add(nudWeight);
            Controls.Add(btnResetForm);
            Controls.Add(btnCalculateBMI);
            Controls.Add(tbStatusOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMetricUnits);
            Controls.Add(btnUSCustomaryUnits);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton btnUSCustomaryUnits;
        private RadioButton btnMetricUnits;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbStatusOutput;
        private Button btnCalculateBMI;
        private Button btnResetForm;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHeightOne;
        private Label lbWeight;
        private Label lbHeightUnitOne;
        private NumericUpDown nudHeightTwo;
        private Label lbHeightUnitTwo;
        private Boolean isUSCustomaryUnits;
        private TextBox tbBMIOutput;
    }
}
