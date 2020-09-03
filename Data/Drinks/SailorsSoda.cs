/*
 * Name: Ethan Seratte
 * Class Name: SailorSoda.cs
 * Purpose: class to represent Sailor's Soda
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
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
        /// gets/sets flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        /// <summary>
        /// gets price
        /// </summary>
        Size s = Size.Small;
        public double Price
        {
            get
            {
                double price = 0;
                if (s == Size.Small) price = 1.42;
                if (s == Size.Medium) price = 1.74;
                if (s == Size.Large) price = 2.07;
                return price;
            }
        }

        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (s == Size.Small) calories = 117;
                if (s == Size.Medium) calories = 153;
                if (s == Size.Large) calories = 205;
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>soda size/flavor</returns>
        public override string ToString()
        {
            Size s = Size.Small;
            SodaFlavor Flavor = SodaFlavor.Cherry;
            if (s == Size.Small)
            {
                if (Flavor == SodaFlavor.Cherry)
                {
                    return "Small Cherry Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Blackberry)
                {
                    return "Small Blackberry Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Grapefruit)
                {
                    return "Small Grapefruit Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Lemon)
                {
                    return "Small Lemon Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Peach)
                {
                    return "Small Peach Sailor's Soda";
                }
                else
                {
                    return "Small Watermelon Sailor's Soda";
                }
            }

            else if (s == Size.Medium)
            {
                if (Flavor == SodaFlavor.Cherry)
                {
                    return "Medium Cherry Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Blackberry)
                {
                    return "Medium Blackberry Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Grapefruit)
                {
                    return "Medium Grapefruit Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Lemon)
                {
                    return "Medium Lemon Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Peach)
                {
                    return "Medium Peach Sailor's Soda";
                }
                else
                {
                    return "Medium Watermelon Sailor's Soda";
                }
            }

            else
            {
                if (Flavor == SodaFlavor.Cherry)
                {
                    return "Large Cherry Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Blackberry)
                {
                    return "Large Blackberry Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Grapefruit)
                {
                    return "Large Grapefruit Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Lemon)
                {
                    return "Large Lemon Sailor's Soda";
                }
                else if (Flavor == SodaFlavor.Peach)
                {
                    return "Large Peach Sailor's Soda";
                }
                else
                {
                    return "Large Watermelon Sailor's Soda";
                }
            }
        }
    }
}