/* Author: Ethan Seratte
 * Name: Side.cs
 * Purpose: Base class from which all sides will be derived
 */ 

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// base class for sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// gets and sets side size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// gets side price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets side calories
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets side special instructions
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }








    }
}
