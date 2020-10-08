using InternationalFoodAB.Classes;
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
        public List<Ingredient> Ingredients { get; set; }
        public frmAddRecipe()
        {
            InitializeComponent();
            cboRecipeType.Items.AddRange(Repository.GetRecipeTypes().Select(x => x.Name).ToArray());
            Ingredients = new List<Ingredient>();
        }
        private void cmdAddIngredient_Click(object sender, EventArgs e)
        {
            lstIngredients.Items.Add(txtIngredientName.Text, txtIngredientAmount.Text);
            Ingredients.Add(new Ingredient(txtIngredientName.Text, txtIngredientAmount.Text));
            txtIngredientName.Text = ""; //Clear textbox
            txtIngredientAmount.Text = ""; //Clear textbox
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(txtRecipeName.Text.Length < 1 || txtDescription.Text.Length < 1  || lstIngredients.Items.Count < 1) //Vet inte om det är bättre att ha ex. txtRecipeName.Text == ""
            {
                MessageBox.Show("En eller fler fält är tomma");
                //(RecipeType)Repository.GetRecipeTypes().Where(x => x.Name == cboRecipeType.SelectedItem.ToString()).FirstOrDefault()
            }
            else
            {
                Recipe recipe = new Recipe(txtRecipeName.Text, txtDescription.Text, new RecipeType(cboRecipeType.SelectedItem.ToString()), Ingredients);
                MessageBox.Show("Recept " + recipe.Name + " tillagt");

                txtRecipeName.Text = "";
                txtDescription.Text = "";
                txtIngredientName.Text = "";
                lstIngredients.Items.Clear();
                Ingredients.Clear();
            }
        }
    }
}
