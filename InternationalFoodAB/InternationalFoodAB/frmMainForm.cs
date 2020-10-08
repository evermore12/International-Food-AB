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
            cmdAddRecipe.Enabled = true; //true temporärt
            Search();
            //grbRecipe.Left = this.Width - grbRecipe.Width / 2;
            //grbSearch.Left = this.Width - grbRecipe.Width / 2;
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
                cmdAddRecipe.Enabled = false; //Kan ine lägga till recept
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
            cmdAddRecipe.Enabled = true; //Kan lägga till recept
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
            Search();

        }

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frmAddRecipe = new frmAddRecipe();
            frmAddRecipe.Show();
        }

        private void Search()
        {
            lstRecipes.Items.Clear();
            string searchText = txtSearchWord.Text;

            RecipeType Cake = new RecipeType("Desserter/kakor", InternationalFoodAB.Properties.Resources.Meat);
            RecipeType Fish = new RecipeType("Fiskrätter", InternationalFoodAB.Properties.Resources.Fish);
            RecipeType Meat = new RecipeType("Kötträtter", InternationalFoodAB.Properties.Resources.Salad);
            RecipeType Salad = new RecipeType("Sallader", InternationalFoodAB.Properties.Resources.Soup);
            RecipeType Soup = new RecipeType("Soppor", InternationalFoodAB.Properties.Resources.Cake);



            List<RecipeType> categories = new List<RecipeType>();
            if (CakeActive) categories.Add(Cake);
            if (FishActive) categories.Add(Fish);
            if (MeatActive) categories.Add(Meat);
            if (SaladActive) categories.Add(Salad);
            if (SoupActive) categories.Add(Soup);
            if (!CakeActive && !FishActive && !MeatActive && !SaladActive && !SoupActive)
            {
                categories.Add(Cake);
                categories.Add(Fish);
                categories.Add(Meat);
                categories.Add(Salad);
                categories.Add(Soup);
            }

            List<ListViewItem> searchResultList = FileManager.SearchRecipe(txtSearchWord.Text, categories);

            foreach (ListViewItem listViewItem in searchResultList)
            {
                lstRecipes.Items.Add(listViewItem);
            }
        }
    }
}