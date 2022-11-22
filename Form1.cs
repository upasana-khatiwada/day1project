namespace day1project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = Username.Text;

            for(int i= 0; i<3; i++) 
            {
                
                MessageBox.Show("Your name is " + data+ i);
                // MessageBox.Show("Error Mesaage");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

