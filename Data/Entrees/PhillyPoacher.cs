/*
 * Name: Ethan Seratte
 * Class Name: PhillyPoacher.cs
 * Purpose: class to represent Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// gets/sets Sirloin bool
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// gets/sets Onion bool
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// gets/sets Roll bool
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public double Price
        {
            get => 7.23;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public uint Calories
        {
            get => 784;
        }

        /// <summary>
        /// gets special instructions of entree
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}

