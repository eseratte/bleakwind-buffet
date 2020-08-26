/*
 * Name: Ethan Seratte
 * Class Name: PhillyPoacher.cs
 * Purpose: class to represent Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class PhillyPoacher
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
        /// <summary>
        /// sets properties of entree
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double Price = 7.23;
            uint Calories = 784;

            bool Sirloin = true;
            bool Onion = true;
            bool Roll = true;

            List<String> SpecialInstructions = new List<string>();

            if (Sirloin == false)
            {
                SpecialInstructions.Add("Hold sirloin");
            }
            if (Onion == false)
            {
                SpecialInstructions.Add("Hold onion");
            }
            if (Roll == false)
            {
                SpecialInstructions.Add("Hold roll");
            }
        }
    }
}

