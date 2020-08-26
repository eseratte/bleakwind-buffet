/*
 * Name: Ethan Seratte
 * Class Name: DragonbornWaffleFries.cs
 * Purpose: class to represent Dragonborn Waffle Fries
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class DragonbornWaffleFries
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>side size</returns>
        public override string ToString()
        {
            Size s = Size.Small;
            if (s == Size.Small)
            {
                return "Small Dragonborn Waffle Fries ";
            }
            else if (s == Size.Medium)
            {
                return "Medium Dragonborn Waffle Fries";
            }
            else
            {
                return "Large Dragonborn Waffle Fries";
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
            Size size = Size.Small;

            if (size == Size.Small)
            {
                price = 0.42;
                calories = 77;
            }
            else if (size == Size.Medium)
            {
                price = 0.76;
                calories = 89;
            }
            else
            {
                price = 0.96;
                calories = 100;
            }
        }
    }
}
