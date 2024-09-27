namespace MRC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - Width, 0);
        }
    }
}