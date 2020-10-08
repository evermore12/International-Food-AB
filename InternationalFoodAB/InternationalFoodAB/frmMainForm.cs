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
        public bool CakeActive { get; set; }
        public bool FishActive { get; set; }
        public bool MeatActive { get; set; }
        public bool SaladActive { get; set; }
        public bool SoupActive { get; set; }

        public bool IsLoggedIn { get; set; }
        public frmMainForm()
        {
            InitializeComponent();

            cboSearchType.Items.Add("Typ");
            cboSearchType.Items.Add("Titel");
            cboSearchType.Items.Add("Beskrivning");
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
        }
        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frmAddRecipe = new frmAddRecipe();
            frmAddRecipe.Show();
        }

        private void picCake_Click(object sender, EventArgs e)
        {
            CakeActive ^= true;

            if (CakeActive) picCake.Image = InternationalFoodAB.Properties.Resources.CakeActive;
            else picCake.Image = InternationalFoodAB.Properties.Resources.Cake;
        }

        private void picFish_Click(object sender, EventArgs e)
        {
            FishActive ^= true;

            if (FishActive) picFish.Image = InternationalFoodAB.Properties.Resources.FishActive;
            else picFish.Image = InternationalFoodAB.Properties.Resources.Fish;
        }

        private void picMeat_Click(object sender, EventArgs e)
        {
            MeatActive ^= true;

            if (MeatActive) picMeat.Image = InternationalFoodAB.Properties.Resources.MeatActive;
            else picMeat.Image = InternationalFoodAB.Properties.Resources.Meat;
        }

        private void picSalad_Click(object sender, EventArgs e)
        {
            SaladActive ^= true;

            if (SaladActive) picSalad.Image = InternationalFoodAB.Properties.Resources.SaladActive;
            else picSalad.Image = InternationalFoodAB.Properties.Resources.Salad;
        }

        private void picSoup_Click(object sender, EventArgs e)
        {
            SoupActive ^= true;

            if (SoupActive) picSoup.Image = InternationalFoodAB.Properties.Resources.SoupActive;
            else picSoup.Image = InternationalFoodAB.Properties.Resources.Soup;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchWord.Text;

            List<string> categories = new List<string>();
            if (CakeActive) categories.Add("Cake");
            if (FishActive) categories.Add("Cake");
            if (MeatActive) categories.Add("Cake");
            if (SaladActive) categories.Add("Cake");
            if (SoupActive) categories.Add("Cake");

            //List<Recipe> searchResult = FileManager.SearchRecipe(searchText, categories);

            //foreach (Recipe recipe in searchResult)
            //{

            //    string[] recipeArray = { recipe.Type.Name, recipe.Name };

            //    ListViewItem listViewItem = new ListViewItem(recipeArray);
            //}
        }
    }
}