/* Name: Ethan Seratte
 * Class Name: DragonbornWaffleFries.cs
 * Purpose: class to represent Dragonborn Waffle Fries
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem
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
                if (Size == Size.Small) price = 0.42;
                if (Size == Size.Medium) price = 0.76;
                if (Size == Size.Large) price = 0.96;
                return price;
            }
        }

        /// <summary>
        /// gets calories
        /// </summary>
        public override  uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small) calories = 77;
                if (Size == Size.Medium) calories = 89;
                if (Size == Size.Large) calories = 100;
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
                return "Small Dragonborn Waffle Fries";
            }
            else if (Size == Size.Medium)
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
