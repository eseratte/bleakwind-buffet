/*
 * Name: Ethan Seratte
 * Class Name: AretinoAppleJuice.cs
 * Purpose: class to represent AretinoAppleJuice
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class AretinoAppleJuice
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>juice size</returns>
        public override string ToString()
        {
            Size s = Size.Small;
            if (s == Size.Small)
            {
                return "Small Aretino Apple Juice";
            }
            else if (s == Size.Medium)
            {
                return "Medium Aretino Apple Juice";
            }
            else
            {
                return "Large Aretino Apple Juice";
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
                price = 0.62;
                calories = 44;
            }
            else if (size == Size.Medium)
            {
                price = 0.87;
                calories = 88;
            }
            else
            {
                price = 1.01;
                calories = 132;
            }
        }
    }
}