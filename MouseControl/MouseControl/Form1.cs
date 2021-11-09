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
            delay();

            int maxScrollNumber = int.Parse(iteration_number_textBox.Text);
            int scrollStep = int.Parse(scroll_step_textBox.Text);
            int msSleep = int.Parse(ms_sleep_time_textBox.Text);

            progressBar2.Maximum = maxScrollNumber;
            for (int i = 0; i < maxScrollNumber; i++)
            {

                MouseOperations.MouseScroll(scrollStep);
                progressBar2.Value = i;
                
                Application.DoEvents();
                Thread.Sleep(msSleep);
            }
            progressBar2.Value = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void delay()
        {
            int delay_ms = int.Parse(delay_ms_textBox.Text);
            int tmp = 100;

            delay_progressBar.Maximum = delay_ms / tmp;
            for (int i = 0; i < delay_ms/tmp; i++)
            {
                delay_progressBar.Value = i;

                Application.DoEvents();
                Thread.Sleep(tmp);
            }
            delay_progressBar.Value = 0;
        }

    }
}
