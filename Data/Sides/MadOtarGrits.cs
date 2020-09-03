/*
 * Name: Ethan Seratte
 * Class Name: MadOtarGrits.cs
 * Purpose: class to represent Mad Otar Grits
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {

        /// <summary>
        /// gets/sets size
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// gets price
        /// </summary>
        Size s = Size.Small;
        public double Price
        {
            get
            {
                double price = 0;
                if (s == Size.Small) price = 1.22;
                if (s == Size.Medium) price = 1.58;
                if (s == Size.Large) price = 1.93;
                return price;
            }
        }

        /// <summary>
        /// gets calories
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (s == Size.Small) calories = 105;
                if (s == Size.Medium) calories = 142;
                if (s == Size.Large) calories = 179;
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

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
    }
}
