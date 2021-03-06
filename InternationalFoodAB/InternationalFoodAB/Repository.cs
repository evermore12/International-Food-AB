﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public static class Repository
    {
        public static List<RecipeType> GetRecipeTypes()
        {
            return new List<RecipeType>
            {
                new RecipeType("Kötträtter", InternationalFoodAB.Properties.Resources.Meat),
                new RecipeType("Fiskrätter", InternationalFoodAB.Properties.Resources.Fish),
                new RecipeType("Sallader", InternationalFoodAB.Properties.Resources.Salad),
                new RecipeType("Soppor", InternationalFoodAB.Properties.Resources.Soup),
                new RecipeType("Desserter/kakor", InternationalFoodAB.Properties.Resources.Cake)
            };
        }
    }
}

    
