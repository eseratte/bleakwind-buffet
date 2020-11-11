/*
 * Name: Ethan Seratte
 * Class Name: Candlehearth Coffee.cs
 * Purpose: class to represent Candlehearth Coffee
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
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
        /// gets/sets decaf
        /// invokes PropertyChanged event handler when Decaf changes
        /// </summary>
        private bool d = false;
        public bool Decaf
        {
            get { return d; }
            set
            {
                d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <summary>
        /// gets/sets cream
        /// invokes PropertyChanged event handler when RoomForCream changes
        /// </summary>
        private bool c = false;
        public bool RoomForCream
        {
            get { return c; }
            set
            {
                c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
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
                    price = 0.75;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Medium)
                {
                    price = 1.25;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Large)
                {
                    price = 1.75;
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
                    calories = 7;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Medium)
                {
                    calories = 10;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Large)
                {
                    calories = 20;
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
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>coffee size/caffiene</returns>
        public override string ToString()
        {
            //bool Decaf = true;
            if (Size == Size.Small)
            {
                if (Decaf == false)
                {
                    return "Small Candlehearth Coffee";
                }
                else
                {
                    return "Small Decaf Candlehearth Coffee";
                }

            }
            else if (Size == Size.Medium)
            {
                if (Decaf == false)
                {
                    return "Medium Candlehearth Coffee";
                }
                else
                {
                    return "Medium Decaf Candlehearth Coffee";
                }
            }
            else
            {
                if (Decaf == false)
                {
                    return "Large Candlehearth Coffee";
                }
                else
                {
                    return "Large Decaf Candlehearth Coffee";
                }
            }
        }

        /// <summary>
        /// gets description of drink
        /// </summary>
        public override string Description
        {
            get
            {
                string description = "Fair trade, fresh ground dark roast coffee.";
                return description;
            }
        }
    }
}