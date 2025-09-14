namespace JokeAndPunchline_Textbook_PP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            lbOutput.Text = "How many programmers does it take to change a lightbulb?";
        }

        private void btnPunchline_Click(object sender, EventArgs e)
        {
            lbOutput.Text = "None. That’s a hardware problem.";
        }
    }
}
