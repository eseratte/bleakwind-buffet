﻿/*
 * Name: Ethan Seratte
 * Class Name: ThugsTBone.cs
 * Purpose: class to represent Thugs T-Bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 6.44;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public override uint Calories
        {
            get => 982;
        }

        /// <summary>
        /// gets special instructions of entree
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
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

        /// <summary>
        /// gets description of entree
        /// </summary>
        public override string Description
        {
            get
            {
                string description = "Juicy T-Bone, not much else to say.";
                return description;
            }
        }
    }
}

