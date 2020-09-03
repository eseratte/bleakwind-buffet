/*
 * Name: Ethan Seratte
 * Class Name: VokunSalad.cs
 * Purpose: class to represent Vokun Salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
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
                if (s == Size.Small) price = 0.93;
                if (s == Size.Medium) price = 1.28;
                if (s == Size.Large) price = 1.82;
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
                if (s == Size.Small) calories = 41;
                if (s == Size.Medium) calories = 52;
                if (s == Size.Large) calories = 73;
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
    }
}
