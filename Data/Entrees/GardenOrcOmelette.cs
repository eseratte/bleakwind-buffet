/*
 * Name: Ethan Seratte
 * Class Name: GardenOrcOmelette.cs
 * Purpose: class to represent Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// gets/sets Broccoli bool
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// gets/sets Mushrooms bool
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// gets/sets Tomato bool
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// gets/sets Cheddar bool
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public double Price
        {
            get => 4.57;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public uint Calories
        {
            get => 404;
        }

        /// <summary>
        /// gets special instructions of entree
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

