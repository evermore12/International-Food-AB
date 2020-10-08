using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternationalFoodAB.Classes
{
    public static class FileManager
    {
        public static string txtRecipesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Remove(AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin\\Debug")), "Resources\\Recipes.txt");
        /// <summary>
        /// Append is true by default
        /// </summary>
        public static void Write(string path, string text, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(path, append))
            {
                writer.WriteLine(text);
            }
        }
        public static List<string> Read(string path)
        {
            string row = "";
            List<string> rows = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                while ((row = reader.ReadLine()) != null)
                {
                    rows.Add(row);
                }
            }
            return rows;
        }

        public static List<Recipe> GetRecipes(string text, List<string> categories)
        {
            List<Recipe> recipeList = new List<Recipe>();
            List<string> recipes = Read(txtRecipesPath);

            foreach (string recipeString in recipes)
            {
                string[] recipeArray = recipeString.Split(';');
                Recipe recipe = new Recipe();

                recipe.Type.Name = recipeArray[0];
                recipe.Name = recipeArray[1];
                recipe.Description = recipeArray[2];

                string[] ingredients = recipeArray[3].Split('|');
                for (int i = 0; i < ingredients.Length; i++)
                {
                    Ingredient ingredient = new Ingredient(ingredients[0])
                    ingredients[0]
                }

            }

            return recipeList;
        }

        //Villkor för sökfunktion som finns på "frmMainForm"
        //public void SearchRecipe(string text, string category)
        //{
        //    foreach (Recipe r in recipes)
        //    {
        //        if (r.Name.ToLower().Contains(text.ToLower()) || r.Type.Name.ToLower().Contains(text.ToLower()))
        //        {
        //          string[] writeRecipe = {r.Type.Name, r.Name};
        //          ListViewItem listViewItem = new ListViewItem(writeRecipe);

        //          lstRecipes.Items.Add(); 
        //        }
        //    }
        //}
    }
}
