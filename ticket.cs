﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSTATIONSERVICE
{
    public partial class ticket : UserControl
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clicButton;
        public ticket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //x
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }
    }
}
