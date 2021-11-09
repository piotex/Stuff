using System;
using System.Threading;
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
            //textBox1.Text = "X: " + MouseOperations.GetCursorPosition().X + " | Y: " + MouseOperations.GetCursorPosition().Y;
            Thread.Sleep(2000);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                MouseOperations.MouseScroll(-i*10);
                progressBar1.Value = i;
                
                Application.DoEvents();
            }
            progressBar1.Value = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
