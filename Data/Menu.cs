/* Author: Ethan Seratte
 * Name: Menu.cs
 * Purpose: creates lists for each item type and full menu
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {   
        /// <summary>
        /// creates a list of IOrderItems containing an instance of each entree
        /// </summary>
        /// <returns>the list of entrees</returns>
        public static List<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            BriarheartBurger b = new BriarheartBurger();
            entreeList.Add(b);
            DoubleDraugr d = new DoubleDraugr();
            entreeList.Add(d);
            GardenOrcOmelette g = new GardenOrcOmelette();
            entreeList.Add(g);
            PhillyPoacher p = new PhillyPoacher();        
            entreeList.Add(p);
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            entreeList.Add(s);
            ThalmorTriple t = new ThalmorTriple();
            entreeList.Add(t);
            ThugsTBone tb = new ThugsTBone();
            entreeList.Add(tb);

            return entreeList;
        }

        /// <summary>
        /// creates a list of IOrderItems containing an instance of each side
        /// </summary>
        /// <returns>the list of sides</returns>
        public static List<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();
           foreach (Size s in Enum.GetValues(typeof(Size))) 
           {
                sideList.Add(new DragonbornWaffleFries() { Size = s });
                sideList.Add(new FriedMiraak() { Size = s });
                sideList.Add(new MadOtarGrits() { Size = s });
                sideList.Add(new VokunSalad() { Size = s });     
           }
            return sideList;
        }

        /// <summary>
        /// creates a list of IOrderItems containing an instance of each drink
        /// </summary>
        /// <returns>the list of drinks</returns>
        public static List<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
          /*AretinoAppleJuice a = new AretinoAppleJuice();
            CandlehearthCoffee c = new CandlehearthCoffee();
            MarkarthMilk m = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater w = new WarriorWater();*/

            foreach (Size s in Enum.GetValues(typeof(Size)))
          {
                drinkList.Add(new AretinoAppleJuice() { Size = s });
                drinkList.Add(new CandlehearthCoffee() { Size = s });
                drinkList.Add(new MarkarthMilk() { Size = s });
                drinkList.Add(new WarriorWater() { Size = s });
                drinkList.Add(new SailorSoda() { Size = s });
                /*a.Size = s;
                drinkList.Add(a);
                c.Size = s;
                drinkList.Add(c);
                m.Size = s;
                drinkList.Add(m);
                ss.Size = s;
                w.Size = s;
                drinkList.Add(w);*/

               foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
              {
                 // ss.Flavor = sf;
                   // drinkList.Add(ss);
              }
           }
            return drinkList;
        }

        /// <summary>
        /// compiles full menu list
        /// </summary>
        /// <returns>the list of every menu item</returns>
        public static List<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Drinks());
            return fullMenu;
        }

        /// <summary>
        /// places every menu item into items list
        /// </summary>
        private static List<IOrderItem> items = FullMenu();

        /// <summary>
        /// gets all menu items in items list
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return items; } }

        /// <summary>
        /// searches menu for string matches, returns all items if no terms
        /// </summary>
        /// <param name="terms">string to search for</param>
        /// <returns>item list</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return All;
            foreach(IOrderItem item in All)
            {
                string name = item.ToString();
                if(name != null && name.Contains(terms))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static string[] ItemType
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

     /// <summary>
     /// filters nullable items by entree/side/drink
     /// </summary>
     /// <param name="items">items to filter</param>
     /// <param name="Categories">category of item</param>
     /// <returns>a list of items</returns>
     public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, string[] Categories)
        {
            //return provided list if no filter
            if (Categories == null || Categories.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {               
                if(item is BleakwindBuffet.Data.Entrees.Entree && Categories.Contains("Entree"))
                {
                    results.Add(item);
                }

                if (item is BleakwindBuffet.Data.Sides.Side && Categories.Contains("Side"))
                {
                    results.Add(item);
                }

                if (item is BleakwindBuffet.Data.Drinks.Drink && Categories.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters nullable items in list by calorie count
        /// </summary>
        /// <param name="items">list of items</param>
        /// <param name="min">minimum calories</param>
        /// <param name="max">maximum calories</param>
        /// <returns>a list of items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            //null check, neither specified
            if(min == null && max == null) return items;
            //min null check, only max specified
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            //max null check, only min specified
            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            //null check, both specified
            foreach(IOrderItem item in items)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters nullable items by price
        /// </summary>
        /// <param name="items">item list</param>
        /// <param name="min">price minimum</param>
        /// <param name="max">price maximum</param>
        /// <returns>a list of items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            //null check, neither specified
            if (min == null && max == null) return items;
            //min null check, only max specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            //max null check, only min specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            //null check, both specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }


    }
}
