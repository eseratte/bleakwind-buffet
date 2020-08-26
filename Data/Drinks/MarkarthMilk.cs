/*
 * Name: Ethan Seratte
 * Class Name: MarkarthMilk.cs
 * Purpose: class to represent Markarth Milk
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class MarkarthMilk
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>milk size</returns>
        public override string ToString()
        {
            Size s = Size.Small;            
            if (s == Size.Small)
            {
                return "Small Markarth Milk";
            }

            else if (s == Size.Medium)
            {
                return "Medium Markarth Milk";
            }

            else
            {
                return "Large Markarth Milk";
            }

        }

        /// <summary>
        /// sets property of side
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double price;
            uint calories;
            List<string> SpecialInstructions = new List<string>();
            Size size = Size.Small;
            bool Ice = false;

            if (Ice == true)
            {
                SpecialInstructions.Add("Add ice");
            }

            if (size == Size.Small)
            {
                price = 1.05;
                calories = 56;
            }
            else if (size == Size.Medium)
            {
                price = 1.11;
                calories = 72;
            }
            else
            {
                price = 1.22;
                calories = 93;
            }
        }
    }
}