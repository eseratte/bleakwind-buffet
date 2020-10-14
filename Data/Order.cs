/* Author: Ethan Seratte
 * Name: Order.cs
 * Purpose: represent an order
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// event invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variables
        /// </summary>
        private static int nextOrderNumber = 1;
        private List<IOrderItem> items;
        private double subtotal;


        /// <summary>
        /// gets and sets SalesTaxRate double
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// gets Subtotal double
        /// </summary>
        public double Subtotal
        {
            get 
            {
                return subtotal;
            }
            set
            {
                subtotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }

        /// <summary>
        /// gets Tax double
        /// </summary>
        public double Tax { get => Subtotal * SalesTaxRate; }

        /// <summary>
        /// gets Total double
        /// </summary>
        public double Total { get => Subtotal + Tax; }

        /// <summary>
        /// gets total calories 
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// gets order number 
        /// </summary>
        public string Number
        {
            get
            {
                string order = "Order Number: " + nextOrderNumber.ToString();
                return order;
            }
            set { }
        }

        public string Name
        {
            get
            {
                return "name of item";
            }
        }

        public double Price
        {
            get
            {
                return 0.00;
            }
        }
      
        public IEnumerable<IOrderItem> Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// Order constructor
        /// </summary>
        public Order()
        {
            //this.Number = nextOrderNumber;
            //nextOrderNumber++;
        }

        /// <summary>
        /// adds item to order
        /// </summary>
        /// <param name="item">the item to add</param>
        public IOrderItem Add
        {
            set
            {
                items.Insert(0, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// removes item from order
        /// </summary>
        /// <param name="item">the item to remove</param>
        public IOrderItem Remove
        {
            set
            {
                bool hasBeenRemoved = false;
                for(int i = 0; i < items.Count; i++)
                {
                    if(items[i] == value) 
                    {
                        items.Remove(value);
                        hasBeenRemoved = true;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    }
                }
                if (!hasBeenRemoved)
                {
                    throw new NotImplementedException("This should not be reached");
                }
            }
        }
    }
}
