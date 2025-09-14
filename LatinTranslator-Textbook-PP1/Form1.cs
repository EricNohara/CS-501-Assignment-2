namespace LatinTranslator_Textbook_PP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbAutem.Text = "up";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbMedium.Text = "center";
        }

        private void btnDescendit_Click(object sender, EventArgs e)
        {
            lbDescendit.Text = "down";
        }
    }
}
