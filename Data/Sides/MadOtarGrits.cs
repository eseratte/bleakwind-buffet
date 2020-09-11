/*
 * Name: Ethan Seratte
 * Class Name: MadOtarGrits.cs
 * Purpose: class to represent Mad Otar Grits
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, IOrderItem
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
                if (Size == Size.Small) price = 1.22;
                if (Size == Size.Medium) price = 1.58;
                if (Size == Size.Large) price = 1.93;
                return price;
            }
        }

        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small) calories = 105;
                if (Size == Size.Medium) calories = 142;
                if (Size == Size.Large) calories = 179;
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
                return "Small Mad Otar Grits";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Mad Otar Grits";
            }
            else
            {
                return "Large Mad Otar Grits";
            }
        }
    }
}
