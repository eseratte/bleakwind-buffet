/*
 * Name: Ethan Seratte
 * Class Name: SailorSoda.cs
 * Purpose: class to represent Sailor's Soda
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
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
        /// gets/sets flavor
        /// invokes PropertyChanged event handler when Flavor changes
        /// </summary>

        private SodaFlavor f = Enums.SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return f; }
            set
            {
                f = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }

        /// <summary>
        /// gets price
        /// invokes PropertyChanged event handler when Price changes
        /// </summary>
        public override double Price
        {
            get
            {
                double price = 0;
                if (Size == Size.Small)
                {
                    price = 1.42;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Medium)
                {
                    price = 1.74;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                if (Size == Size.Large)
                {
                    price = 2.07;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                return price;
            }
        }

        /// <summary>
        /// gets calories
        /// invokes PropertyChanged event handler when Calories changes
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 0;
                if (Size == Size.Small)
                {
                    calories = 117;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Medium)
                {
                    calories = 153;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                if (Size == Size.Large)
                {
                    calories = 205;
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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>soda size/flavor</returns>
        public override string ToString()
        {
            
            //SodaFlavor Flavor = SodaFlavor.Cherry;
            if (Size == Size.Small)
            {
                if (Flavor == SodaFlavor.Cherry)
                {
                    return "Small Cherry Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Blackberry)
                {
                    return "Small Blackberry Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Grapefruit)
                {
                    return "Small Grapefruit Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Lemon)
                {
                    return "Small Lemon Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Peach)
                {
                    return "Small Peach Sailor Soda";
                }
                else
                {
                    return "Small Watermelon Sailor Soda";
                }
            }

            else if (Size == Size.Medium)
            {
                if (Flavor == SodaFlavor.Cherry)
                {
                    return "Medium Cherry Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Blackberry)
                {
                    return "Medium Blackberry Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Grapefruit)
                {
                    return "Medium Grapefruit Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Lemon)
                {
                    return "Medium Lemon Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Peach)
                {
                    return "Medium Peach Sailor Soda";
                }
                else
                {
                    return "Medium Watermelon Sailor Soda";
                }
            }

            else
            {
                if (Flavor == SodaFlavor.Cherry)
                {
                    return "Large Cherry Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Blackberry)
                {
                    return "Large Blackberry Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Grapefruit)
                {
                    return "Large Grapefruit Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Lemon)
                {
                    return "Large Lemon Sailor Soda";
                }
                else if (Flavor == SodaFlavor.Peach)
                {
                    return "Large Peach Sailor Soda";
                }
                else
                {
                    return "Large Watermelon Sailor Soda";
                }
            }
        }
    }
}