/* Author: Ethan Seratte
 * Name: IOrderItem.cs
 * Purpose: Interface to be implemented in every orderable item
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for orderable items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// gets price of ordered item
        /// </summary>
        /// <returns></returns>
        double Price { get; }

        /// <summary>
        /// gets calories of ordered item
        /// </summary>
        /// <returns></returns>
        uint Calories { get; }

        /// <summary>
        /// gets special instructions of ordered item
        /// </summary>
        /// <returns></returns>
        List<string> SpecialInstructions { get; }




    }
}
