/* Author: Ethan Seratte
 * Name: Drink.cs
 * Purpose: Base class from which all drinks will be derived
 */ 

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// base class for drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// gets and sets drink size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// gets drink price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets drink calories
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets drink special instructions
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }

        public abstract string Description { get; }
    }
}
