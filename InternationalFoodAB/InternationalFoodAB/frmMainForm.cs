using InternationalFoodAB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalFoodAB
{
    public partial class frmMainForm : Form
    {

        public bool IsLoggedIn { get; set; }
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            //   Account account = new Account();
            //  account.CheckInlog(); test

           
            //Logga ut funktion
            if (IsLoggedIn)
            {
                ucLogIn uclogin1 = new ucLogIn(this);
                 uclogin1.Show();
                MessageBox.Show("Du har loggat ut");
                IsLoggedIn = false;
                lblAccount.Text = "Ej inloggad";
                cmdLogIn.Text = "Logga in";
                //      cmdLogIn_Click = CheckIn
                //     lblAccount
            }
            else
            {
                ucLogIn logInContron = new ucLogIn(this);
                this.Controls.Add(logInContron);
                logInContron.Show();
                logInContron.BringToFront();
            }    
        }
        public void LoggedIn(string email)
        {
            cmdLogIn.Text = "Logga ut";
            lblAccount.Text = "Inloggad som: " + email;
            cmdAddRecipe.Enabled = true;
        }
        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frmAddRecipe = new frmAddRecipe();
            frmAddRecipe.Show();
        }
    }
}