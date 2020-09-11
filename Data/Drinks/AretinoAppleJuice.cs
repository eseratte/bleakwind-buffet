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
    public class AretinoAppleJuice : Drink, IOrderItem
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
                if (Size == Size.Small) price = 0.62;
                if (Size == Size.Medium) price = 0.87;
                if (Size == Size.Large) price = 1.01;
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
                if (Size == Size.Small) calories = 44;
                if (Size == Size.Medium) calories = 88;
                if (Size == Size.Large) calories = 132;
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
        /// <returns>juice size</returns>
        public override string ToString()
        {            
            if (Size == Size.Small)
            {
                return "Small Aretino Apple Juice";
            }
            else if (Size == Size.Medium)
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