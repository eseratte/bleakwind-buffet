/*
 * Name: Ethan Seratte
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: class to represent Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// gets/sets SausageLink bool
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// gets/sets Egg bool
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// gets/sets HashBrowns bool
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// gets/sets Pancake bool
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 5.62;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public override uint Calories
        {
            get => 602;
        }

        /// <summary>
        /// gets special instructions of entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}

