/*
 * Name: Ethan Seratte
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: class to represent Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets/sets SausageLink bool
        /// </summary>
        private bool s = true;
        public bool SausageLink
        {
            get { return s; }
            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
            }
        }

        /// <summary>
        /// gets/sets Egg bool
        /// </summary>
        private bool e = true;
        public bool Egg
        {
            get { return e; }
            set
            {
                e = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        /// <summary>
        /// gets/sets HashBrowns bool
        /// </summary>
        private bool h = true;
        public bool HashBrowns
        {
            get { return h; }
            set
            {
                h = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
            }
        }
        /// <summary>
        /// gets/sets Pancake bool
        /// </summary>
        private bool p = true;
        public bool Pancake
        {
            get { return p; }
            set
            {
                p = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }

        /// <summary>
        /// gets price of entree
        /// </summary>
        /// <param name="args"></param>    
        public override double Price
        {
            get => 5.62;
        }

        /// <summary>
        /// gets calories of entree
        /// </summary>
        public override uint Calories
        {
            get => 602;
        }

        /// <summary>
        /// gets special instructions of entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// overwrites ToString func
        /// </summary>
        /// <returns>entree name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

        /// <summary>
        /// gets description of entree
        /// </summary>
        public override string Description
        {
            get
            {
                string description = "Put some meat on those bones with a small stack of pancakes." +
                    " Includes sausage links, egss, and hash browns on the side. " +
                    "Topped with the syrup of your choice.";
                return description;
            }
        }
    }
}

