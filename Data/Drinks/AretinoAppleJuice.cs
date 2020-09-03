/*
 * Name: Ethan Seratte
 * Class Name: AretinoAppleJuice.cs
 * Purpose: class to represent AretinoAppleJuice
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// gets/sets ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// gets/sets size 
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// gets drink price
        /// </summary>    
        Size s = Size.Small;
        public double Price
        {
            get
            {
                double price = 0;
                if (s == Size.Small) price = 0.62;
                if (s == Size.Medium) price = 0.87;
                if (s == Size.Large) price = 1.01;
                return price;
            }
        }

        /// <summary>
        /// gets calories of drink
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (s == Size.Small) calories = 44;
                if (s == Size.Medium) calories = 88;
                if (s == Size.Large) calories = 132;
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions of drink
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

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
    }
}