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
            RecipeTypeList = new List<RecipeType> { new RecipeType("Kötträtter", InternationalFoodAB.Properties.Resources.meat),
                                                    new RecipeType("Fiskrätter", InternationalFoodAB.Properties.Resources.fish),
                                                    new RecipeType("Sallader", InternationalFoodAB.Properties.Resources.salad),
                                                    new RecipeType("Soppor", InternationalFoodAB.Properties.Resources.soup),
                                                    new RecipeType("Desserter/kakor", InternationalFoodAB.Properties.Resources.cake)};







        }

    }
}
