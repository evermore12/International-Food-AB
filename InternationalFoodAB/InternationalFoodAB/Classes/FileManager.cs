using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<Recipe> GetRecipes()
        {
            List<Recipe> recipeList = new List<Recipe>();
            List<string> recipes = Read(txtRecipesPath);

            foreach (string recipeString in recipes)
            {
                string[] recipeArray = recipeString.Split(';');
                Recipe recipe = new Recipe();
                recipe.Type = new RecipeType("");

                recipe.Type.Name = recipeArray[0];
                recipe.Name = recipeArray[1];
                recipe.Description = recipeArray[2];

                string[] ingredients = recipeArray[3].Split('|');
                for (int i = 0; i < ingredients.Length; i++)
                {
                    string[] ingredientArray = ingredients[i].Split('%');
                    Ingredient ingredient = new Ingredient(ingredientArray[0], ingredientArray[1]);
                    recipe.Ingredients.Add(ingredient);
                }
            }

            return recipeList;
        }

        //Villkor för sökfunktion som finns på "frmMainForm"
        public static List<ListViewItem> SearchRecipe(string text, List<RecipeType> typeList)
        {
            List<ListViewItem> returnList = new List<ListViewItem>();

            List<Recipe> recipeList = GetRecipes();

            var lambdaList = recipeList.Where(recipe => typeList.Any(type => type.Name == recipe.Type.Name) && recipe.ToString().Contains(text));


            foreach (var recipe in lambdaList)
            {

                string[] listItemArray = { recipe.Type.Name, recipe.Name };

                ListViewItem listItem = new ListViewItem(listItemArray);
                returnList.Add(listItem);
            }

            return returnList;
        }
    }
}
