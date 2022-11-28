using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterrrrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button3.Height;
            home1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/_WUC");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/waterutilities");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit App?","Exit Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes);
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height=button3.Height;
            Sidepanel.Top = button3.Top;
            home1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height=button1.Height;
            Sidepanel.Top = button1.Top;
            customer1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height=button2.Height;    
            Sidepanel.Top = button2.Top;
            tariff1.BringToFront();
        }
    }
}
