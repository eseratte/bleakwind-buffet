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
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            FriedMiraak f = new FriedMiraak();
            MadOtarGrits m = new MadOtarGrits();
            VokunSalad v = new VokunSalad();

            //foreach (Size s in Enum.GetValues(typeof(Size))) 
           // {
               // d.Size = s;
                sideList.Add(d);
               // f.Size = s;
                sideList.Add(f);
               // m.Size = s;
                sideList.Add(m);
               // v.Size = s;
                sideList.Add(v);    
           // }
            return sideList;
        }

        /// <summary>
        /// creates a list of IOrderItems containing an instance of each drink
        /// </summary>
        /// <returns>the list of drinks</returns>
        public static List<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            AretinoAppleJuice a = new AretinoAppleJuice();
            CandlehearthCoffee c = new CandlehearthCoffee();
            MarkarthMilk m = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater w = new WarriorWater();

            //foreach (Size s in Enum.GetValues(typeof(Size)))
            //{
                //a.Size = s;
                drinkList.Add(a);
                //c.Size = s;
                drinkList.Add(c);
                //m.Size = s;
                drinkList.Add(m);
                //ss.Size = s;
                //w.Size = s;
                drinkList.Add(w);

               // foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
               // {
                   // ss.Flavor = sf;
                    drinkList.Add(ss);
               // }
            //}
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





    }
}
