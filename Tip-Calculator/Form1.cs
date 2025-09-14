namespace Tip_Calculator
{
    public partial class form_tipCalculator : Form
    {
        public form_tipCalculator()
        {
            InitializeComponent();
        }

        // When clicking into the cost box, the placeholder text is gone.
        private void tbox_enterCost_Enter(object sender, EventArgs e)
        {
            tbox_enterCost.ForeColor = Color.Black;
            if (tbox_enterCost.Text == "Enter cost")
            {
                tbox_enterCost.Text = string.Empty;
            }
        }

        // When clicking out, if there is nothing entered, reset to placeholder
        private void tbox_enterCost_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbox_enterCost.Text))
            {
                tbox_enterCost.Text = "Enter cost";
                tbox_enterCost.ForeColor = Color.Gray;
            }
        }

        private void tbar_tipPercent_Scroll(object sender, EventArgs e)
        {
            double cost;
            try
            {
                cost = double.Parse(tbox_enterCost.Text);
            }
            catch (Exception)
            {
                cost = 0.0;
            }
            tbox_tipPercent.Text = tbar_tipPercent.Value.ToString() + "%";
            double tipAmount = cost * tbar_tipPercent.Value / 100;
            tbox_tipAmount.Text = "$" + tipAmount.ToString("F2");
            tbox_totalCost.Text = "$" + (cost + tipAmount).ToString("F2");
        }

        private void tbox_enterCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(tbox_enterCost.Text);
                if (cost < 0) { throw new Exception(); }
                double tipAmount = cost * tbar_tipPercent.Value / 100;
                tbox_tipAmount.Text = "$" + tipAmount.ToString("F2");
                tbox_totalCost.Text = "$" + (cost + tipAmount).ToString("F2");
            }
            catch (Exception)
            {
                if (tbox_enterCost.Text != "Enter cost")
                {
                    tbox_enterCost.Text = string.Empty;
                }
            }
        }
    }
}
