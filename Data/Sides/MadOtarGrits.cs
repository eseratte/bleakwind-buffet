/*
 * Name: Ethan Seratte
 * Class Name: MadOtarGrits.cs
 * Purpose: class to represent Mad Otar Grits
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class MadOtarGrits
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
                return "Small Mad Otar Grits";
            }
            else if (s == Size.Medium)
            {
                return "Medium Mad Otar Grits";
            }
            else
            {
                return "Large Mad Otar Grits";
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
                price = 1.22;
                calories = 105;
            }
            else if (size == Size.Medium)
            {
                price = 1.58;
                calories = 142;
            }
            else
            {
                price = 1.93;
                calories = 179;
            }
        }
    }
}
