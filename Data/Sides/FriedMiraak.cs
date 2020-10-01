/*
 * Name: Ethan Seratte
 * Class Name: FriedMiraak.cs
 * Purpose: class to represent Fried Miraak
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
        /// gets price
        /// </summary>        
        public override double Price
        {
            get
            {
                double price = 0;
                if (Size == Size.Small) 
                {
                    price = 1.78;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Medium)
                {
                    price = 2.01;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Large)
                {
                    price = 2.88;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                return price;
            }
        }

        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small)
                {
                    calories = 151;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Medium)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    calories = 236;
                }
                if (Size == Size.Large) 
                { 
                    calories = 306;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                return calories;
            }
        }

        /// <summary>
        /// gets special instructions
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
        /// <returns>side size</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Fried Miraak";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Fried Miraak";
            }
            else
            {
                return "Large Fried Miraak";
            }
        }
    }
}
