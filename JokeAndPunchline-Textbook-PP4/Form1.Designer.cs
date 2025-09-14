namespace JokeAndPunchline_Textbook_PP4
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
            btnSetup = new Button();
            btnPunchline = new Button();
            lbOutput = new Label();
            SuspendLayout();
            // 
            // btnSetup
            // 
            btnSetup.Location = new Point(270, 144);
            btnSetup.Name = "btnSetup";
            btnSetup.Size = new Size(395, 114);
            btnSetup.TabIndex = 0;
            btnSetup.Text = "setup";
            btnSetup.UseVisualStyleBackColor = true;
            btnSetup.Click += btnSetup_Click;
            // 
            // btnPunchline
            // 
            btnPunchline.Location = new Point(935, 144);
            btnPunchline.Name = "btnPunchline";
            btnPunchline.Size = new Size(395, 114);
            btnPunchline.TabIndex = 1;
            btnPunchline.Text = "punchline";
            btnPunchline.UseVisualStyleBackColor = true;
            btnPunchline.Click += btnPunchline_Click;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Location = new Point(757, 435);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(0, 32);
            lbOutput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 873);
            Controls.Add(lbOutput);
            Controls.Add(btnPunchline);
            Controls.Add(btnSetup);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSetup;
        private Button btnPunchline;
        private Label lbOutput;
    }
}
