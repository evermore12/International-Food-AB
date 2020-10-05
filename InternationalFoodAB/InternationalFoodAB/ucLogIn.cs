using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalFoodAB
{
    public partial class ucLogIn : UserControl
    {

        public frmMainForm MainForm { get; set; }
        public ucLogIn(frmMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;
        }

        //TO-DO: logga ut knapp när vi är inloggad.

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            Account logIn = new Account(txtEmail.Text, txtPassword.Text);

            if (logIn.CheckInlog())
            {
                MessageBox.Show("Korrekt inloggning");
                MainForm.IsLoggedIn = true;
                MainForm.LoggedIn(txtEmail.Text);
                this.Hide();
            }
            else MessageBox.Show("Felaktig inloggning");

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
