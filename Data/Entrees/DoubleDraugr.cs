﻿/*
 * Name: Ethan Seratte
 * Class Name: DoubleDragur.cs
 * Purpose: class to represent Double Draugr
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets/sets Bun bool
        /// invokes PropertyChanged event handler when Bun changes
        /// </summary>       
        private bool b = true;
        public bool Bun
        {
            get { return b; }
            set
            {
                b = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        /// <summary>
        /// gets/sets Ketchup bool
        /// invokes PropertyChanged event handler when Ketchup changes
        /// </summary>
        private bool k = true;
        public bool Ketchup
        {
            get { return k; }
            set
            {
                k = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <summary>
        /// gets/sets Mustard bool
        /// invokes PropertyChanged event handler when Mustard changes
        /// </summary>
        private bool m = true;
        public bool Mustard
        {
            get { return m; }
            set
            {
                m = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <summary>
        /// gets/sets Pickle bool
        /// invokes PropertyChanged event handler when Pickle changes
        /// </summary>
        private bool p = true;
        public bool Pickle
        {
            get { return p; }
            set
            {
                p = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }


        /// <summary>
        /// gets/sets Cheese bool
        /// invokes PropertyChanged event handler when Cheese changes
        /// </summary>
        private bool c = true;
        public bool Cheese
        {
            get { return c; }
            set
            {
                c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
        /// gets/sets Lettuce bool
        /// invokes PropertyChanged event handler when Lettuce changes
        /// </summary>
        private bool l = true;
        public bool Lettuce
        {
            get { return l; }
            set
            {
                l = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <summary>
        /// gets/sets Mayo bool
        /// </summary>
        private bool ma = true;
        public bool Mayo
        {
            get { return ma; }
            set
            {
                ma = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// gets price of burger
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 7.32;
        }

        /// <summary>
        /// gets calories of burger
        /// </summary>
        public override uint Calories
        {
            get => 843;
        }

        /// <summary>
        /// gets special instructions of burger
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }

        /// <summary>
        /// gets description of entree
        /// </summary>
        public override string Description
        {
            get
            {
                string description = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
                return description;
            }
        }
    }
}

