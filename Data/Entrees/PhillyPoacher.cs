/*
 * Name: Ethan Seratte
 * Class Name: PhillyPoacher.cs
 * Purpose: class to represent Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets/sets Sirloin bool
        /// invokes PropertyChanged event handler when Sirloin changes
        /// </summary>
        private bool s = true;
        public bool Sirloin
        {
            get { return s; }
            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        /// <summary>
        /// gets/sets Onion bool
        /// invokes PropertyChanged event handler when Onion changes
        /// </summary>
        private bool o = true;
        public bool Onion
        {
            get { return o; }
            set
            {
                o = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
            }
        }

        /// <summary>
        /// gets/sets Roll bool
        /// </summary>
        private bool r = true;
        public bool Roll
        {
            get { return r; }
            set
            {
                r = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
        }

        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 7.23;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public override uint Calories
        {
            get => 784;
        }

        /// <summary>
        /// gets special instructions of entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}

