/*
 * Name: Ethan Seratte
 * Class Name: WarriorWater.cs
 * Purpose: class to represent Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem
    {
        /// <summary>
        /// gets/sets ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// gets/sets size
        /// </summary>
        public override Size Size { get; set; } = Size.Small;

        /// <summary>
        /// gets/sets lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// gets drink price
        /// </summary>
        public override double Price
        {
            get
            {
                double price = 0;
                return price;
            }
        }

        /// <summary>
        /// gets drink calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
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
                if (Ice == false) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>water size</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Warrior Water";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Warrior Water";
            }
            else
            {
                return "Large Warrior Water";
            }
        }
    }
}