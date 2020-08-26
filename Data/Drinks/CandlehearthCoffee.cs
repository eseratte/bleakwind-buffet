/*
 * Name: Ethan Seratte
 * Class Name: Candlehearth Coffee.cs
 * Purpose: class to represent Candlehearth Coffee
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class CandlehearthCoffee
    {
        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>coffee size/caffiene</returns>
        public override string ToString()
        {
            Size s = Size.Small;
            bool Decaf = false;
            if (s == Size.Small)
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
            else if (s == Size.Medium)
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
            bool Ice = false;
            bool RoomForCream = false;           

            if (Ice == true)
            {
                SpecialInstructions.Add("Add ice");
            }
            if (RoomForCream == true)
            {
                SpecialInstructions.Add("Add cream");
            }

            if (size == Size.Small)
            {
                price = 0.62;
                calories = 44;
            }
            else if (size == Size.Medium)
            {
                price = 0.87;
                calories = 88;
            }
            else
            {
                price = 1.01;
                calories = 132;
            }
        }
    }
}