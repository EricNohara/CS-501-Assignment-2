namespace LatinTranslator_Textbook_PP1
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
            btnAutem = new Button();
            btnDescendit = new Button();
            btnMedium = new Button();
            lbAutem = new Label();
            lbDescendit = new Label();
            lbMedium = new Label();
            SuspendLayout();
            // 
            // btnAutem
            // 
            btnAutem.Location = new Point(180, 97);
            btnAutem.Name = "btnAutem";
            btnAutem.Size = new Size(326, 95);
            btnAutem.TabIndex = 0;
            btnAutem.Text = "autem";
            btnAutem.UseVisualStyleBackColor = true;
            btnAutem.Click += button1_Click;
            // 
            // btnDescendit
            // 
            btnDescendit.Location = new Point(180, 289);
            btnDescendit.Name = "btnDescendit";
            btnDescendit.Size = new Size(326, 95);
            btnDescendit.TabIndex = 1;
            btnDescendit.Text = "descendit";
            btnDescendit.UseVisualStyleBackColor = true;
            btnDescendit.Click += btnDescendit_Click;
            // 
            // btnMedium
            // 
            btnMedium.Location = new Point(180, 479);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(326, 95);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += button3_Click;
            // 
            // lbAutem
            // 
            lbAutem.AutoSize = true;
            lbAutem.Location = new Point(674, 128);
            lbAutem.Name = "lbAutem";
            lbAutem.Size = new Size(0, 32);
            lbAutem.TabIndex = 3;
            // 
            // lbDescendit
            // 
            lbDescendit.AutoSize = true;
            lbDescendit.Location = new Point(674, 320);
            lbDescendit.Name = "lbDescendit";
            lbDescendit.Size = new Size(0, 32);
            lbDescendit.TabIndex = 4;
            // 
            // lbMedium
            // 
            lbMedium.AutoSize = true;
            lbMedium.Location = new Point(674, 510);
            lbMedium.Name = "lbMedium";
            lbMedium.Size = new Size(0, 32);
            lbMedium.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 833);
            Controls.Add(lbMedium);
            Controls.Add(lbDescendit);
            Controls.Add(lbAutem);
            Controls.Add(btnMedium);
            Controls.Add(btnDescendit);
            Controls.Add(btnAutem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAutem;
        private Button btnDescendit;
        private Button btnMedium;
        private Label lbAutem;
        private Label lbDescendit;
        private Label lbMedium;
    }
}
