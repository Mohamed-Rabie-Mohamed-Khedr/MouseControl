namespace MRC
{
    public partial class ControlRoom : Form
    {
        const int VK_RCONTROL = 0xA3;
        const int VK_LCONTROL = 0xA2;
        const int VK_RSHIFT = 0xA1;
        const int VK_LSHIFT = 0xA0;
        const int VK_RALT = 0xA5;
        const int VK_LALT = 0xA4;

        public ControlRoom()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.controlRoomIsRun = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName + ".exe");
            string[] d = Program.RaedData();
            numericUpDown1.Value = int.Parse(d[0]);
            textBox1.Text = d[1];
            textBox2.Text = d[2];
            textBox3.Text = d[3];
            textBox4.Text = d[4];
            textBox5.Text = d[5];
            textBox6.Text = d[6];
            textBox7.Text = d[7];
            textBox8.Text = d[8];
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.KeyState(VK_LCONTROL)) ((TextBox)sender).Text = "LControlKey";
            else if (Program.KeyState(VK_RCONTROL)) ((TextBox)sender).Text = "RControlKey";
            else if (Program.KeyState(VK_RSHIFT)) ((TextBox)sender).Text = "RShiftKey";
            else if (Program.KeyState(VK_LSHIFT)) ((TextBox)sender).Text = "LShiftKey";
            else if (Program.KeyState(VK_RALT)) ((TextBox)sender).Text = "RMenu";
            else if (Program.KeyState(VK_LALT)) ((TextBox)sender).Text = "LMenu";
            else ((TextBox)sender).Text = e.KeyCode.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("save.txt", $"{numericUpDown1.Value},{textBox1.Text},{textBox2.Text},{textBox3.Text},{textBox4.Text},{textBox5.Text},{textBox6.Text},{textBox7.Text},{textBox8.Text}");
            Program.KeysUpdate();
            Close();
        }
    }
}