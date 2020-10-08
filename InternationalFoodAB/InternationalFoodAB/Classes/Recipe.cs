using InternationalFoodAB.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public class Recipe
    {
        //
        public string Name { get; set; }
        public string Description { get; set; }
        public RecipeType Type { get; set; }
        public List<Ingredient> IngredientList { get; set; }
        public Recipe()
        {
            
        }
        public void Add(Recipe recipe)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath =  Path.Combine(basePath.Remove(basePath.IndexOf("bin\\Debug")), "Resources\\Recipes.txt");
            FileManager.Write(fullPath, "Temp");
        }
    }
}
