namespace Tip_Calculator
{
    partial class form_tipCalculator
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
            tbar_tipPercent = new TrackBar();
            label_tip = new Label();
            label_total = new Label();
            tbox_tipAmount = new TextBox();
            tbox_totalCost = new TextBox();
            tbox_tipPercent = new TextBox();
            tbox_enterCost = new TextBox();
            label_dollarSign = new Label();
            ((System.ComponentModel.ISupportInitialize)tbar_tipPercent).BeginInit();
            SuspendLayout();
            // 
            // tbar_tipPercent
            // 
            tbar_tipPercent.Location = new Point(109, 81);
            tbar_tipPercent.Maximum = 100;
            tbar_tipPercent.Name = "tbar_tipPercent";
            tbar_tipPercent.Size = new Size(366, 56);
            tbar_tipPercent.TabIndex = 2;
            tbar_tipPercent.Scroll += tbar_tipPercent_Scroll;
            // 
            // label_tip
            // 
            label_tip.AutoSize = true;
            label_tip.Font = new Font("Segoe UI", 15F);
            label_tip.Location = new Point(34, 141);
            label_tip.Name = "label_tip";
            label_tip.Size = new Size(49, 35);
            label_tip.TabIndex = 4;
            label_tip.Text = "Tip";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Font = new Font("Segoe UI", 15F);
            label_total.Location = new Point(34, 203);
            label_total.Name = "label_total";
            label_total.Size = new Size(68, 35);
            label_total.TabIndex = 5;
            label_total.Text = "Total";
            // 
            // tbox_tipAmount
            // 
            tbox_tipAmount.BackColor = Color.FromArgb(255, 224, 192);
            tbox_tipAmount.Enabled = false;
            tbox_tipAmount.Font = new Font("Segoe UI", 15F);
            tbox_tipAmount.Location = new Point(109, 141);
            tbox_tipAmount.Name = "tbox_tipAmount";
            tbox_tipAmount.ReadOnly = true;
            tbox_tipAmount.Size = new Size(366, 41);
            tbox_tipAmount.TabIndex = 8;
            tbox_tipAmount.Text = "$0.00";
            // 
            // tbox_totalCost
            // 
            tbox_totalCost.BackColor = Color.FromArgb(255, 224, 192);
            tbox_totalCost.Font = new Font("Segoe UI", 15F);
            tbox_totalCost.Location = new Point(109, 203);
            tbox_totalCost.Name = "tbox_totalCost";
            tbox_totalCost.ReadOnly = true;
            tbox_totalCost.Size = new Size(366, 41);
            tbox_totalCost.TabIndex = 9;
            tbox_totalCost.Text = "$0.00";
            // 
            // tbox_tipPercent
            // 
            tbox_tipPercent.BackColor = SystemColors.Menu;
            tbox_tipPercent.BorderStyle = BorderStyle.None;
            tbox_tipPercent.Font = new Font("Segoe UI", 15F);
            tbox_tipPercent.Location = new Point(34, 81);
            tbox_tipPercent.Name = "tbox_tipPercent";
            tbox_tipPercent.ReadOnly = true;
            tbox_tipPercent.Size = new Size(68, 34);
            tbox_tipPercent.TabIndex = 10;
            tbox_tipPercent.Text = "0%";
            // 
            // tbox_enterCost
            // 
            tbox_enterCost.Font = new Font("Segoe UI", 15F);
            tbox_enterCost.ForeColor = Color.Gray;
            tbox_enterCost.Location = new Point(61, 34);
            tbox_enterCost.Name = "tbox_enterCost";
            tbox_enterCost.Size = new Size(414, 41);
            tbox_enterCost.TabIndex = 11;
            tbox_enterCost.Text = "Enter cost";
            tbox_enterCost.TextChanged += tbox_enterCost_TextChanged;
            tbox_enterCost.Enter += tbox_enterCost_Enter;
            tbox_enterCost.Leave += tbox_enterCost_Leave;
            // 
            // label_dollarSign
            // 
            label_dollarSign.AutoSize = true;
            label_dollarSign.Font = new Font("Segoe UI", 15F);
            label_dollarSign.Location = new Point(34, 37);
            label_dollarSign.Name = "label_dollarSign";
            label_dollarSign.Size = new Size(28, 35);
            label_dollarSign.TabIndex = 12;
            label_dollarSign.Text = "$";
            // 
            // form_tipCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(label_dollarSign);
            Controls.Add(tbox_enterCost);
            Controls.Add(tbox_tipPercent);
            Controls.Add(tbox_totalCost);
            Controls.Add(tbox_tipAmount);
            Controls.Add(label_total);
            Controls.Add(label_tip);
            Controls.Add(tbar_tipPercent);
            Name = "form_tipCalculator";
            Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)tbar_tipPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar tbar_tipPercent;
        private Label label_dollarSign;
        private Label label_tip;
        private Label label_total;
        private TextBox tbox_tipAmount;
        private TextBox tbox_totalCost;
        private TextBox tbox_tipPercent;
        private TextBox tbox_enterCost;
    }
}
