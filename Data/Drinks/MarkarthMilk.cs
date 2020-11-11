/*
 * Name: Ethan Seratte
 * Class Name: MarkarthMilk.cs
 * Purpose: class to represent Markarth Milk
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets/sets ice
        /// invokes PropertyChanged event handler when Ice changes
        /// </summary>
        private bool i = false;
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
        /// invokes PropertyChanged event handler when Price changes
        /// </summary>               
        public override double Price
        {
            get
            {
                double price = 0;
                if (Size == Size.Small)
                {
                    price = 1.05;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Medium)
                {
                    price = 1.11;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Large)
                {
                    price = 1.22;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                return price;
            }
        }

        /// <summary>
        /// gets calories of drink
        /// invokes PropertyChanged event handler when Calories changes
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small)
                {
                    calories = 56;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Medium)
                {
                    calories = 72;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Large)
                {
                    calories = 93;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
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
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>milk size</returns>
        public override string ToString()
        {                     
            if (Size == Size.Small)
            {
                return "Small Markarth Milk";
            }

            else if (Size == Size.Medium)
            {
                return "Medium Markarth Milk";
            }

            else
            {
                return "Large Markarth Milk";
            }

        }

        /// <summary>
        /// gets description of drink
        /// </summary>
        public override string Description
        {
            get
            {
                string description = "Hormone-free organic 2% milk.";
                return description;
            }
        }
    }
}