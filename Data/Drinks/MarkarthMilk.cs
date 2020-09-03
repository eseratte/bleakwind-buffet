/*
 * Name: Ethan Seratte
 * Class Name: MarkarthMilk.cs
 * Purpose: class to represent Markarth Milk
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {

        /// <summary>
        /// gets/sets ice
        /// </summary>
        public bool Ice { get; set; } = false;

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
                if (s == Size.Small) price = 1.05;
                if (s == Size.Medium) price = 1.11;
                if (s == Size.Large) price = 1.22;
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
                if (s == Size.Small) calories = 56;
                if (s == Size.Medium) calories = 72;
                if (s == Size.Large) calories = 93;
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
        /// <returns>milk size</returns>
        public override string ToString()
        {
            Size s = Size.Small;            
            if (s == Size.Small)
            {
                return "Small Markarth Milk";
            }

            else if (s == Size.Medium)
            {
                return "Medium Markarth Milk";
            }

            else
            {
                return "Large Markarth Milk";
            }

        }
    }
}