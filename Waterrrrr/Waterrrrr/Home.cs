﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Waterrrrr
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 3)
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }

            else
            {
                count = 0;
            }
        }
    }
}
