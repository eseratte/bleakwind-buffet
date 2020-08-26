/*
 * Name: Ethan Seratte
 * Class Name: BriarheartBurger.cs
 * Purpose: class to represent Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class BriarheartBurger
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
        /// <summary>
        /// sets properties of entree
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double Price = 6.32;
            uint Calories = 743;

            bool Bun = true;
            bool Ketchup = true;
            bool Mustard = true;
            bool Pickles = true;
            bool Cheese = true;

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
        }
    }
}

