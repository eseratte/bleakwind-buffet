/*
 * Name: Ethan Seratte
 * Class Name: GardenOrcOmelette.cs
 * Purpose: class to represent Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets/sets Broccoli bool
        /// invokes PropertyChanged event handler when Broccoli changes
        /// </summary>
        private bool b = true;
        public bool Broccoli
        {
            get { return b; }
            set
            {
                b = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
            }
        }
        /// <summary>
        /// gets/sets Mushrooms bool
        /// invokes PropertyChanged event handler when Mushrooms changes
        /// </summary>
        private bool m = true;
        public bool Mushrooms
        {
            get { return m; }
            set
            {
                m = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
            }
        }

        /// <summary>
        /// gets/sets Tomato bool
        /// invokes PropertyChanged event handler when Tomato changes
        /// </summary>
        private bool t = true;
        public bool Tomato
        {
            get { return t; }
            set
            {
                t = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// gets/sets Cheddar bool
        /// invokes PropertyChanged event handler when Cheddar changes
        /// </summary>
        private bool c = true;
        public bool Cheddar
        {
            get { return c; }
            set
            {
                c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
            }
        }

        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 4.57;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public override uint Calories
        {
            get => 404;
        }

        /// <summary>
        /// gets special instructions of entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

