namespace HeadsOrTails_Textbook_PP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            headOrTailsCoin.Image = Image.FromFile("C:\\Users\\ericn\\source\\repos\\CS-501-Assignment-2\\HeadsOrTails-Textbook-PP5\\images\\heads.jpg");
        }

        private void btnShowTails_Click(object sender, EventArgs e)
        {
            headOrTailsCoin.Image = Image.FromFile("C:\\Users\\ericn\\source\\repos\\CS-501-Assignment-2\\HeadsOrTails-Textbook-PP5\\images\\tails.jpg");
        }
    }
}
