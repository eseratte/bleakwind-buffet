/*
 * Name: Ethan Seratte
 * Class Name: ThalmorTriple.cs
 * Purpose: class to represent Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, IOrderItem
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
            /// gets/sets Tomato bool
            /// </summary>
            public bool Tomato { get; set; } = true;

            /// <summary>
            /// gets/sets Lettuce bool
            /// </summary>
            public bool Lettuce { get; set; } = true;

            /// <summary>
            /// gets/sets Mayo bool
            /// </summary>
            public bool Mayo { get; set; } = true;

        /// <summary>
        /// gets/sets Bacon bool
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// gets/sets Egg bool
        /// </summary>
        public bool Egg { get; set; } = true;


        /// <summary>
        /// gets price of burger
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
            {
                get => 8.32;
            }

            /// <summary>
            /// gets calories of burger
            /// </summary>
            public override uint Calories
            {
                get => 943;
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
                    if (!Tomato) instructions.Add("Hold tomato");
                    if (!Lettuce) instructions.Add("Hold lettuce");
                    if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                    return instructions;
                }
            }

            /// <summary>
            /// overwrites ToString func
            /// </summary>
            /// <returns>entree name</returns>
            public override string ToString()
            {
                return "Thalmor Triple";
            }
        }
}

