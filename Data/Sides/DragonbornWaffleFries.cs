/*
 * Name: Ethan Seratte
 * Class Name: DragonbornWaffleFries.cs
 * Purpose: class to represent Dragonborn Waffle Fries
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
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
                if (s == Size.Small) price = 0.42;
                if (s == Size.Medium) price = 0.76;
                if (s == Size.Large) price = 0.96;
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
                if (s == Size.Small) calories = 77;
                if (s == Size.Medium) calories = 89;
                if (s == Size.Large) calories = 100;
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
    }
}
