/*
 * Name: Ethan Seratte
 * Class Name: Candlehearth Coffee.cs
 * Purpose: class to represent Candlehearth Coffee
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// gets/sets ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// gets/sets decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// gets/sets ice
        /// </summary>
        public bool RoomForCream { get; set; } = false;

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
                if (Size == Size.Small) price = 0.75;
                if (Size == Size.Medium) price = 1.25;
                if (Size == Size.Large) price = 1.75;
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
                if (Size == Size.Small) calories = 7;
                if (Size == Size.Medium) calories = 10;
                if (Size == Size.Large) calories = 20;
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
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>coffee size/caffiene</returns>
        public override string ToString()
        {
            //bool Decaf = true;
            if (Size == Size.Small)
            {
                if (Decaf == false)
                {
                    return "Small Candlehearth Coffee";
                }
                else
                {
                    return "Small Decaf Candlehearth Coffee";
                }

            }
            else if (Size == Size.Medium)
            {
                if (Decaf == false)
                {
                    return "Medium Candlehearth Coffee";
                }
                else
                {
                    return "Medium Decaf Candlehearth Coffee";
                }
            }
            else
            {
                if (Decaf == false)
                {
                    return "Large Candlehearth Coffee";
                }
                else
                {
                    return "Large Decaf Candlehearth Coffee";
                }
            }
        }
    }
}