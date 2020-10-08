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
        public Recipe NewRecipe { get; set; }
        public frmAddRecipe()
        {
            InitializeComponent();
        }
        private void frmAddRecipe_Load(object sender, EventArgs e)
        {
            NewRecipe = new Recipe();
            NewRecipe.IngredientList = new List<Ingredient>();
        }
        private void cmdAddIngredient_Click(object sender, EventArgs e)
        {
            lstIngredients.Items.Add(txtIngredient.Text);
        }


    }
}
