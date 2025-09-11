namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            int heightOne = (int)nudHeightOne.Value;
            int heightTwo = (int)nudHeightTwo.Value;
            int weight = (int)nudWeight.Value;

            double heightInInches = (heightOne * 12) + heightTwo;
            double heightInMeters = heightOne + (heightTwo / 100.0);

            double bmi = isUSCustomaryUnits
                ? (703.0 * weight) / Math.Pow(heightInInches, 2)
                : weight / Math.Pow(heightInMeters, 2);

            tbBMIOutput.Text = $"BMI: {bmi}";

            string status;

            if (bmi < 18.5)
            {
                status = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                status = "Healthy Weight";
            }
            else if (bmi <= 29.9)
            {
                status = "Overweight";
            }
            else
            {
                status = "Obesity";
            }

            tbStatusOutput.Text = status;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUSCustomaryUnits_CheckedChanged(object sender, EventArgs e)
        {
            lbHeightUnitOne.Text = "Feet (ft)";
            lbHeightUnitTwo.Text = "Inches (in)";
            lbWeight.Text = "Pounds (lbs)";
            nudHeightTwo.Maximum = 11;
            isUSCustomaryUnits = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbHeightUnitOne.Text = "Meters (m)";
            lbHeightUnitTwo.Text = "Centimeters (cm)";
            lbWeight.Text = "Kilograms (kg)";
            nudHeightTwo.Maximum = 99;
            isUSCustomaryUnits = false;
        }

        private void nudHeightTwo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbStatusOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            nudHeightOne.Value = 0;
            nudHeightTwo.Value = 0;
            nudWeight.Value = 0;
            tbBMIOutput.Text = string.Empty;
            tbStatusOutput.Text = string.Empty;
        }
    }
}
