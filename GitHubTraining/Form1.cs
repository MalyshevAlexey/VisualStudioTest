﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test button pressed");
        }

        private void buttonAlexey_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changed Text Alexey button pressed");
        }
        private void buttonGintaras_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Gintaras button pressed");
        }
    }
}
