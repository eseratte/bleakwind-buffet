/*
 * Name: Ethan Seratte
 * Class Name: VokunSalad.cs
 * Purpose: class to represent Vokun Salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class VokunSalad
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
                return "Small Vokun Salad";
            }
            else if (s == Size.Medium)
            {
                return "Medium Vokun Salad";
            }
            else
            {
                return "Large Vokun Salad";
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

            if(size == Size.Small)
            {
                price = 0.93;
                calories = 41;
            }
            else if(size == Size.Medium)
            {
                price = 1.28;
                calories = 52;
            }
            else
            {
                price = 1.82;
                calories = 73;
            }
        }
    }
}
