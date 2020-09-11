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
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// gets/sets size
        /// </summary>
        public override Size Size { get; set; } = Enums.Size.Small;

        /// <summary>
        /// gets price
        /// </summary>
        public override double Price
        {
            get
            {
                double price = 0;
                if (Size == Size.Small) price = 0.93;
                if (Size == Size.Medium) price = 1.28;
                if (Size == Size.Large) price = 1.82;
                return price;
            }
        }

        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small) calories = 41;
                if (Size == Size.Medium) calories = 52;
                if (Size == Size.Large) calories = 73;
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions
        /// </summary>
        public override List<String> SpecialInstructions
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
            if (Size == Size.Small)
            {
                return "Small Vokun Salad";
            }
            else if (Size == Size.Medium)
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
