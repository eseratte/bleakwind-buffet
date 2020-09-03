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
    public class WarriorWater
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
        /// gets/sets lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// gets drink price
        /// </summary>
        public double Price
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
        public double Calories
        {
            get
            {
                double calories = 0;
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
                if (!Ice) instructions.Add("Hold ice");
                if (!Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>water size</returns>
        public override string ToString()
        {
            Size s = Size.Small;
            if (s == Size.Small)
            {
                return "Small Warrior Water";
            }
            else if (s == Size.Medium)
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