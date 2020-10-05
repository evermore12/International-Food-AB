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
        public ucLogIn()
        {
            InitializeComponent();
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            Account adminlogin = new Account();
            adminlogin.Email = "Admin1@gmail.com";
            adminlogin.Password = "King123";

            if (textBox1.Text.Equals(adminlogin.Email) && textBox2.Text.Equals(adminlogin.Password));
            {
                adminlogin.AdminLogin();
                MessageBox.Show("Inloggning funkar.");
            }
          
            

        }
    }
}
