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
    public partial class frmAddRecipe : Form
    {
        public frmAddRecipe()
        {
            InitializeComponent();
            cboRecipeType.Items.AddRange(Repository.GetRecipeTypes().ToArray()); 
        }
        private void cmdAddIngredient_Click(object sender, EventArgs e)
        {
            lstIngredients.Items.Add(txtIngredient.Text);
            txtIngredient.Text = ""; //Clear textbox
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(txtRecipeName.Text.Length < 1 || txtDescription.Text.Length < 1  || lstIngredients.Items.Count < 1) //Vet inte om det är bättre att ha ex. txtRecipeName.Text == ""
            {
                MessageBox.Show("En eller fler fält är tomma");
            }
            else
            {
                Recipe recipe = new Recipe(txtRecipeName.Text, txtDescription.Text, (RecipeType)cboRecipeType.SelectedItem, new List<Ingredient>()); //Inte helt klar, måste få ingridients från listbox till recept konstruktorn
                MessageBox.Show("Recept " + recipe.Name + " tillagt");

                txtRecipeName.Text = "";
                txtDescription.Text = "";
                txtIngredient.Text = "";
                lstIngredients.Items.Clear();
            }
        }
    }
}
