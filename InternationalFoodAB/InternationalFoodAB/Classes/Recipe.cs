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
        private string txtFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Remove(AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin\\Debug")), "Resources\\Recipes.txt"); //Fint
        public RecipeType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Recipe(string name, string descption, RecipeType type, List<Ingredient> ingredients)
        {
            FileManager.Write()
        }
        public void Add(Recipe recipe)
        {
            throw new NotImplementedException();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath =  Path.Combine(basePath.Remove(basePath.IndexOf("bin\\Debug")), "Resources\\Recipes.txt");
            FileManager.Write(fullPath, "Temp");
        }
    }
}
