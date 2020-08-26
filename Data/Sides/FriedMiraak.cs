/*
 * Name: Ethan Seratte
 * Class Name: FriedMiraak.cs
 * Purpose: class to represent Fried Miraak
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class FriedMiraak
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
                return "Small Fried Miraak";
            }
            else if (s == Size.Medium)
            {
                return "Medium Fried Miraak";
            }
            else
            {
                return "Large Fried Miraak";
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
                price = 1.78;
                calories = 151;
            }
            else if (size == Size.Medium)
            {
                price = 2.01;
                calories = 236;
            }
            else
            {
                price = 2.88;
                calories = 306;
            }
        }
    }
}
