/*
 * Name: Ethan Seratte
 * Class Name: WarriorWater.cs
 * Purpose: class to represent Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class WarriorWater
    {
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

        /// <summary>
        /// sets property of side
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            double price = 0.00;
            uint calories = 0;
            List<string> SpecialInstructions = new List<string>();
            Size size = Size.Small;
            bool Ice = true;
            bool Lemon = false;

            if (Ice == false)
            {
                SpecialInstructions.Add("Hold ice");
            }
            if (Lemon == true)
            {
                SpecialInstructions.Add("Add lemon");
            }         
        }
    }
}