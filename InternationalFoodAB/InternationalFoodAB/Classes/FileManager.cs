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

        //public List<Recipe> SearchRecipe(string text, List<string> categories)
        //{
        //    List<string> recipes = Read(Path.Combine(basePath.Remove(basePath.IndexOf("bin\\Debug")), "Resources\\Recipes.txt"));

        //}

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
