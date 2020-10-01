/*
 * Name: Ethan Seratte
 * Class Name: BriarheartBurger.cs
 * Purpose: class to represent Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
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
        /// gets price of burger
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 6.32;
        }

        /// <summary>
        /// gets calories of burger
        /// </summary>
        public override uint Calories
        {
            get => 743;
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
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}


