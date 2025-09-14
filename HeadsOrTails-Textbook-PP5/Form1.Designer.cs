namespace HeadsOrTails_Textbook_PP5
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
            btnShowHeads = new Button();
            btnShowTails = new Button();
            headOrTailsCoin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)headOrTailsCoin).BeginInit();
            SuspendLayout();
            // 
            // btnShowHeads
            // 
            btnShowHeads.Location = new Point(304, 433);
            btnShowHeads.Name = "btnShowHeads";
            btnShowHeads.Size = new Size(244, 121);
            btnShowHeads.TabIndex = 0;
            btnShowHeads.Text = "Show Heads";
            btnShowHeads.UseVisualStyleBackColor = true;
            btnShowHeads.Click += button1_Click;
            // 
            // btnShowTails
            // 
            btnShowTails.Location = new Point(773, 433);
            btnShowTails.Name = "btnShowTails";
            btnShowTails.Size = new Size(244, 121);
            btnShowTails.TabIndex = 1;
            btnShowTails.Text = "Show Tails";
            btnShowTails.UseVisualStyleBackColor = true;
            btnShowTails.Click += btnShowTails_Click;
            // 
            // headOrTailsCoin
            // 
            headOrTailsCoin.Location = new Point(495, 101);
            headOrTailsCoin.Name = "headOrTailsCoin";
            headOrTailsCoin.Size = new Size(400, 260);
            headOrTailsCoin.TabIndex = 2;
            headOrTailsCoin.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 802);
            Controls.Add(headOrTailsCoin);
            Controls.Add(btnShowTails);
            Controls.Add(btnShowHeads);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)headOrTailsCoin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowHeads;
        private Button btnShowTails;
        private PictureBox headOrTailsCoin;
    }
}
