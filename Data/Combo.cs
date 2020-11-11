/* Author: Ethan Seratte
 * Name: Combo.cs
 * Purpose: Represent a combination of Drink, Side, and Entree
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Combo : INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// invoked when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variables
        /// </summary>
        private Entree entree;
        private Side side;
        private Drink drink;
        
        /// <summary>
        /// getter/setter for entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// getter for entree name
        /// </summary>
        public string EntreeName { get { return entree.ToString(); } }

        /// <summary>
        /// getter/setter for side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// getter for side name
        /// </summary>
        public string SideName { get { return side.ToString(); } }

        /// <summary>
        /// getter/setter for drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));               
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// getter for drink name
        /// </summary>
        public string DrinkName { get { return drink.ToString(); } }

        /// <summary>
        /// getter for combo items calories
        /// </summary>
        public uint Calories
        {
            get 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                return entree.Calories + side.Calories + drink.Calories;

            }
        }

        /// <summary>
        /// getter for combo items price
        /// </summary>
        public double Price
        {
            get
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                return entree.Price + side.Price + drink.Price - 1;
            }
        }

        /// <summary>
        /// getter/setter for combo items special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructionsList = new List<string>();
                specialInstructionsList.Add(entree.ToString());
                specialInstructionsList.AddRange(entree.SpecialInstructions);
                specialInstructionsList.Add(side.ToString());
                specialInstructionsList.AddRange(side.SpecialInstructions);
                specialInstructionsList.Add(drink.ToString());
                specialInstructionsList.AddRange(drink.SpecialInstructions);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return specialInstructionsList;
            }
        }

        public string Description
        {
            get
            {
                string description = entree.Description + " | " + side.Description + " | " + drink.Description;
                return description;
            }
        }
    }
}
