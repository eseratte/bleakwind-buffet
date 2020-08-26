/*
 * Name: Ethan Seratte
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: class to represent Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class SmokehouseSkeleton
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
        /// <summary>
        /// sets properties of entree
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double Price = 5.62;
            uint Calories = 602;

            bool Sausage = true;
            bool Egg = true;
            bool Hashbrown = true;
            bool Pancake = true;

            List<String> SpecialInstructions = new List<string>();

            if (Sausage == false)
            {
                SpecialInstructions.Add("Hold sausage");
            }
            if (Egg == false)
            {
                SpecialInstructions.Add("Hold egg");
            }
            if (Hashbrown == false)
            {
                SpecialInstructions.Add("Hold hash browns");
            }
            if (Pancake == false)
            {
                SpecialInstructions.Add("Hold pancake");
            }
        }
    }
}

