using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public class Repository
    {
        public List<RecipeType> RecipeTypeList { get; set; }

        public Repository()
        {
            RecipeTypeList = new List<RecipeType> { new RecipeType("Kötträtter", InternationalFoodAB.Properties.Resources.Meat),
                                                    new RecipeType("Fiskrätter", InternationalFoodAB.Properties.Resources.Fish),
                                                    new RecipeType("Sallader", InternationalFoodAB.Properties.Resources.Salad),
                                                    new RecipeType("Soppor", InternationalFoodAB.Properties.Resources.Soup),
                                                    new RecipeType("Desserter/kakor", InternationalFoodAB.Properties.Resources.Cake)};
        }

        //public void SearchRecipe(string text, string category)
        //{
        //    if (cboSearchType == "Typ" && RecipeType.ToLower().Contains(text))
        //    {
                //Add the result here
        //    }
        //    else if (cboSearchType == "Titel" && RecipeTitle.ToLower().Contains(text))
        //    {
                //Add the result here
        //    }
        //    else if (cboSearchType == "Beskrivning" && RecipeDescription.ToLower().Contains(text))
        //    {
                //Add the result here
        //    }
        //}
    }
}
