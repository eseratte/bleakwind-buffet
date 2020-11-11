/*
 * Name: Ethan Seratte
 * Class Name: WarriorWater.cs
 * Purpose: class to represent Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets/sets ice
        /// invokes PropertyChanged event handler when Ice changes
        /// </summary>
        private bool i = true;
        public bool Ice
        {
            get { return i; }
            set
            {
                i = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// gets/sets lemon
        /// invokes PropertyChanged event handler when Lemon changes
        /// </summary>
        private bool l = true;
        public bool Lemon
        {
            get { return l; }
            set
            {
                l = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }

        /// <summary>
        /// gets/sets size
        /// invokes PropertyChanged event handler when Size changes
        /// </summary>
        private Size s = Enums.Size.Small;
        public override Size Size
        {
            get { return s; }

            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// gets drink price
        /// </summary>
        public override double Price
        {
            get
            {
                double price = 0;
                return price;
            }
        }

        /// <summary>
        /// gets drink calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions of drink
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice == false) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>water size</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Warrior Water";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Warrior Water";
            }
            else
            {
                return "Large Warrior Water";
            }
        }

        /// <summary>
        /// gets description of drink
        /// </summary>
        public override string Description
        {
            get
            {
                string description = "It's water. Just water.";
                return description;
            }
        }
    }
}