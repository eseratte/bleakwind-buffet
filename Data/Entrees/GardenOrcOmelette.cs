/*
 * Name: Ethan Seratte
 * Class Name: GardenOrcOmelette.cs
 * Purpose: class to represent Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class GardenOrcOmelette
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
        /// <summary>
        /// sets properties of entree
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double Price = 4.57;
            uint Calories = 404;

            bool Broccoli = true;
            bool Mushroom = true;
            bool Tomato = true;
            bool Cheddar = true;

            List<String> SpecialInstructions = new List<string>();

            if (Broccoli == false)
            {
                SpecialInstructions.Add("Hold broccoli");
            }
            if (Mushroom == false)
            {
                SpecialInstructions.Add("Hold mushrooms");
            }
            if (Tomato == false)
            {
                SpecialInstructions.Add("Hold tomato");
            }
            if (Cheddar == false)
            {
                SpecialInstructions.Add("Hold cheddar");
            }
        }
    }
}

