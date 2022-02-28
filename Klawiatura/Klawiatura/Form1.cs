using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace Klawiatura
{
    public partial class Form1 : Form
    {
        private KeyHandler ghk;
        public Form1()
        {
            ghk = new KeyHandler(Keys.NumPad0, this);
            ghk.Register();
            InitializeComponent();

            while (true)
            {
                Thread.Sleep(1000);
                SimulateSpaceKeyPress();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SimulateSpaceKeyPress()
        {
            SendKeys.Send(".");
            // Do stuff...
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                SimulateSpaceKeyPress();
            base.WndProc(ref m);
        }
    }
}
