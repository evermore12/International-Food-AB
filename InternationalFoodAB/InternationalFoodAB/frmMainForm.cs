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
            ucLogIn logInContron = new ucLogIn(this);
            this.Controls.Add(logInContron);
            logInContron.Show();
            logInContron.BringToFront();
        }

        public void LoggedIn(string email)
        {
            lblAccount.Text = "Inloggad som: " + email;
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            string kek = Environment.CurrentDirectory;
            string lol = AppDomain.CurrentDomain.BaseDirectory;
            string mmm = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"Classes\Resources\ErrorLog.txt");
            string path = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), @"Data\Names.txt");
            string path2 = AppDomain.CurrentDomain.BaseDirectory;
            string path3 = path2.Substring(0, path.Length -5);
            FileManager.Write(path, "Hej", true);
        }
    }
}
