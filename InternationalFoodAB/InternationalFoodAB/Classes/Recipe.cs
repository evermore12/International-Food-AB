using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public RecipeType Type { get; set; }
        public List<Ingredient> IngredientList { get; set; }
        public Recipe()
        {

        }
    }
}
