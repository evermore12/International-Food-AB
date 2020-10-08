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
        public RecipeType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Recipe(string name, string description, RecipeType type, List<Ingredient> ingredients)
        {
            //Eller direkt i frmAddRecipe?
            FileManager.Write(FileManager.txtRecipesPath, string.Format("{0};{1};{2}|{3}%{4}", name, description, type.Name, string.Join("|", ingredients.Select(x => x.Name)),
                                                                        string.Join("%", ingredients.Select(x => x.Amount)))); 
        }
        public Recipe()
        {

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
