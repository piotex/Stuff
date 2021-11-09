using System;
using System.Windows.Forms;

namespace MouseControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void scrool_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "X: " + MouseOperations.GetCursorPosition().X + " | Y: " + MouseOperations.GetCursorPosition().Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
