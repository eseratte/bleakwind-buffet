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
    public class MarkarthMilk : Drink, IOrderItem 
    {

        /// <summary>
        /// gets/sets ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// gets/sets size 
        /// </summary>
        public override Size Size { get; set; } = Enums.Size.Small;

        /// <summary>
        /// gets drink price
        /// </summary>               
        public override double Price
        {
            get
            {
                double price = 0;
                if (Size == Size.Small) price = 1.05;
                if (Size == Size.Medium) price = 1.11;
                if (Size == Size.Large) price = 1.22;
                return price;
            }
        }

        /// <summary>
        /// gets calories of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small) calories = 56;
                if (Size == Size.Medium) calories = 72;
                if (Size == Size.Large) calories = 93;
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions of drink
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>milk size</returns>
        public override string ToString()
        {                     
            if (Size == Size.Small)
            {
                return "Small Markarth Milk";
            }

            else if (Size == Size.Medium)
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