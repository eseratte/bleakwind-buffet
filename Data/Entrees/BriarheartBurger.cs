/*
 * Name: Ethan Seratte
 * Class Name: BriarheartBurger.cs
 * Purpose: class to represent Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem
    {
        /// <summary>
        /// gets/sets Bun bool
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// gets/sets Ketchup bool
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// gets/sets Mustard bool
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// gets/sets Pickle bool
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// gets/sets Cheese bool
        /// </summary>
        public bool Cheese { get; set; } = true;                 

        /// <summary>
        /// gets price of burger
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 6.32;
        }

        /// <summary>
        /// gets calories of burger
        /// </summary>
        public override uint Calories
        {
            get => 743;
        }

        /// <summary>
        /// gets special instructions of burger
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}


