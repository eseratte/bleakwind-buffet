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
    public class FriedMiraak : Side, IOrderItem
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
                if (Size == Size.Small) price = 1.78;
                if (Size == Size.Medium) price = 2.01;
                if (Size == Size.Large) price = 2.88;
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
                if (Size == Size.Small) calories = 151;
                if (Size == Size.Medium) calories = 236;
                if (Size == Size.Large) calories = 306;
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
                return "Small Fried Miraak";
            }
            else if (Size == Size.Medium)
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
