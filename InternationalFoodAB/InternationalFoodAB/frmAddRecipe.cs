using System;
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
    public partial class frmAddRecipe : Form
    {
        public Recipe Recipe { get; set; }
        public frmAddRecipe()
        {
            InitializeComponent();
        }        
        private void cmdAddIngredient_Click(object sender, EventArgs e)
        {
            //NewRecipe();
            //Recipe.IngredientList.Add(new Ingredient(txtIngredient.Text));
            lstIngredients.Items.Add(txtIngredient.Text);
            txtIngredient.Text = ""; //Clear textbox
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int kek = txtRecipeName.Text.Length;
            int lol = txtDescription.Text.Length;
            int hey = lstIngredients.Items.Count;
            if(txtRecipeName.Text.Length < 1 || txtDescription.Text.Length < 1  || lstIngredients.Items.Count < 1) //Vet inte om det är bättre att ha ex. txtRecipeName.Text == ""
            {
                MessageBox.Show("En eller fler fält är tomma");
            }
            else
            {
                 //Lite konstig funktion
                MessageBox.Show("Recept " + Recipe.Name + " tillagt");
                ResetAll();
            }
        }
        private void ResetAll()
        {
            txtRecipeName.Text = "";
            txtDescription.Text = "";
            txtIngredient.Text = "";
            lstIngredients.Items.Clear();
        }
        private void NewRecipe()
        {
            Recipe = new Recipe();
            Recipe.IngredientList = new List<Ingredient>();
        }
    }
}
