/*
 * Name: Ethan Seratte
 * Class Name: FriedMiraak.cs
 * Purpose: class to represent Fried Miraak
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
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
                if (s == Size.Small) price = 1.78;
                if (s == Size.Medium) price = 2.01;
                if (s == Size.Large) price = 2.88;
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
                if (s == Size.Small) calories = 151;
                if (s == Size.Medium) calories = 236;
                if (s == Size.Large) calories = 306;
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
    }
}
