/* Author: Ethan Seratte
 * Name: Entree.cs
 * Purpose: Base class from which all entrees will be derived
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// base class for entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// gets entree price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets entree calories
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets entree special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
