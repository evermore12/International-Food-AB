﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalFoodAB
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucLogIn logInContron = new ucLogIn(this);
            this.Controls.Add(logInContron);
            logInContron.Show();
            logInContron.BringToFront();
        }
    }
}
