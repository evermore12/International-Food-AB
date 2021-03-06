﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public class Ingredient
    {
        public string Name { get; set; }
        public Image Picture { get; set; }
        public string Amount { get; set; }
        public Ingredient(string name, Image picture)
        {
            Name = name;
            Picture = picture;
        }
        public Ingredient(string name, string amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
