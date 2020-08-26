/*
 * Name: Ethan Seratte
 * Class Name: ThalmorTriple.cs
 * Purpose: class to represent Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class ThalmorTriple
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "ThalmorTriple";
        }
        /// <summary>
        /// sets properties of entree
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double Price = 8.32;
            uint Calories = 943;

            bool Bun = true;
            bool Ketchup = true;
            bool Mustard = true;
            bool Pickles = true;
            bool Cheese = true;
            bool Tomato = true;
            bool Lettuce = true;
            bool Mayo = true;
            bool Bacon = true;
            bool Egg = true;

            List<String> SpecialInstructions = new List<string>();

            if (Bun == false)
            {
                SpecialInstructions.Add("Hold bun");
            }
            if (Ketchup == false)
            {
                SpecialInstructions.Add("Hold ketchup");
            }
            if (Mustard == false)
            {
                SpecialInstructions.Add("Hold mustard");
            }
            if (Pickles == false)
            {
                SpecialInstructions.Add("Hold pickle");
            }
            if (Cheese == false)
            {
                SpecialInstructions.Add("Hold cheese");
            }
            if (Tomato == false)
            {
                SpecialInstructions.Add("Hold tomato");
            }
            if (Lettuce == false)
            {
                SpecialInstructions.Add("Hold lettuce");
            }
            if (Mayo == false)
            {
                SpecialInstructions.Add("Hold mayo");
            }
            if (Bacon == false)
            {
                SpecialInstructions.Add("Hold bacon");
            }
            if (Egg == false)
            {
                SpecialInstructions.Add("Hold egg");
            }
        }
    }
}

