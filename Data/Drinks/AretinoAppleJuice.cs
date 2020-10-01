/*
 * Name: Ethan Seratte
 * Class Name: AretinoAppleJuice.cs
 * Purpose: class to represent AretinoAppleJuice
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
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
                    price = 0.62;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Medium)
                {
                    price = 0.87;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Large)
                {
                    price = 1.01;
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
                    calories = 44;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Medium)
                {
                    calories = 88;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Large)
                {
                    calories = 132;
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
        /// <returns>juice size</returns>
        public override string ToString()
        {            
            if (Size == Size.Small)
            {
                return "Small Aretino Apple Juice";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Aretino Apple Juice";
            }
            else
            {
                return "Large Aretino Apple Juice";
            }
        }
    }
}