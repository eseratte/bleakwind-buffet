/*
 * Name: Ethan Seratte
 * Class Name: SailorSoda.cs
 * Purpose: class to represent Sailor's Soda
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class SailorSoda
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>soda size/flavor</returns>
        public override string ToString()
        {
            Size s = Size.Small;
            SodaFlavor f = SodaFlavor.Cherry;
            if (s == Size.Small)
            {
                if (f == SodaFlavor.Cherry)
                {
                    return "Small Cherry Sailor's Soda";
                }
                else if (f == SodaFlavor.Blackberry)
                {
                    return "Small Blackberry Sailor's Soda";
                }
                else if (f == SodaFlavor.Grapefruit)
                {
                    return "Small Grapefruit Sailor's Soda";
                }
                else if (f == SodaFlavor.Lemon)
                {
                    return "Small Lemon Sailor's Soda";
                }
                else if (f == SodaFlavor.Peach)
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
                if (f == SodaFlavor.Cherry)
                {
                    return "Medium Cherry Sailor's Soda";
                }
                else if (f == SodaFlavor.Blackberry)
                {
                    return "Medium Blackberry Sailor's Soda";
                }
                else if (f == SodaFlavor.Grapefruit)
                {
                    return "Medium Grapefruit Sailor's Soda";
                }
                else if (f == SodaFlavor.Lemon)
                {
                    return "Medium Lemon Sailor's Soda";
                }
                else if (f == SodaFlavor.Peach)
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
                if (f == SodaFlavor.Cherry)
                {
                    return "Large Cherry Sailor's Soda";
                }
                else if (f == SodaFlavor.Blackberry)
                {
                    return "Large Blackberry Sailor's Soda";
                }
                else if (f == SodaFlavor.Grapefruit)
                {
                    return "Large Grapefruit Sailor's Soda";
                }
                else if (f == SodaFlavor.Lemon)
                {
                    return "Large Lemon Sailor's Soda";
                }
                else if (f == SodaFlavor.Peach)
                {
                    return "Large Peach Sailor's Soda";
                }
                else
                {
                    return "Large Watermelon Sailor's Soda";
                }
            }

        }

        /// <summary>
        /// sets property of side
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double price;
            uint calories;
            List<string> SpecialInstructions = new List<string>();
            Size size = Size.Small;
            bool Ice = true;
            SodaFlavor Flavor = SodaFlavor.Cherry;

            if(Ice == false)
            {
                SpecialInstructions.Add("Hold ice");
            }

            if (size == Size.Small)
            {
                price = 1.42;
                calories = 117;
            }
            else if (size == Size.Medium)
            {
                price = 1.74;
                calories = 153;
            }
            else
            {
                price = 2.07;
                calories = 205;
            }
        }
    }
}