/* Author: Ethan Seratte
 * Name: MenuTests.cs
 * Purpose: Test Menu.cs class in the Data library
 */ 

using Xunit;


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnCorrectEntreeList()
        {
            List<IOrderItem> entreeList = Menu.Entrees();
            Assert.Equal(7, entreeList.Count);
            /*BriarheartBurger b = new BriarheartBurger();
            DoubleDraugr d = new DoubleDraugr();
            GardenOrcOmelette g = new GardenOrcOmelette();
            PhillyPoacher p = new PhillyPoacher();
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            ThalmorTriple t = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();

            Assert.Collection(entreeList,
                item => Assert.Equal(b, item),
                item => Assert.Equal(d, item),
                item => Assert.Equal(g, item),
                item => Assert.Equal(p, item),
                item => Assert.Equal(s, item),
                item => Assert.Equal(t, item),
                item => Assert.Equal(tb, item)
                );*/
        }

        [Fact]
        public void ShouldReturnCorrectDrinkList()
        {
            List<IOrderItem> drinkList = Menu.Drinks();
            Assert.Equal(5, drinkList.Count);
            /*AretinoAppleJuice a = new AretinoAppleJuice();
            CandlehearthCoffee c = new CandlehearthCoffee();
            MarkarthMilk m = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater w = new WarriorWater();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                a.Size = s;
                c.Size = s;
                m.Size = s;
                ss.Size = s;
                w.Size = s;
            
                Assert.Collection(drinkList,
                item => Assert.Equal(a, item),
                item => Assert.Equal(c, item),
                item => Assert.Equal(m, item),
                item => Assert.Equal(w, item),
                item => Assert.Equal(ss, item)
                );

                /*foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    ss.Flavor = sf;
                    Assert.Collection(drinkList,
                    item => Assert.Equal(ss, item)
                );
                }
            }*/
        }

        [Fact]
        public void ShouldReturnCorrectSideList()
        {
            List<IOrderItem> sideList = Menu.Sides();
            Assert.Equal(4, sideList.Count);
            /*DragonbornWaffleFries d = new DragonbornWaffleFries();
            FriedMiraak f = new FriedMiraak();
            MadOtarGrits m = new MadOtarGrits();
            VokunSalad v = new VokunSalad();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                //d.Size = s;
                //f.Size = s;
                //m.Size = s;
                //v.Size = s;

                Assert.Collection(sideList,
                item => Assert.Equal(d, item),
                item => Assert.Equal(f, item),
                item => Assert.Equal(m, item),
                item => Assert.Equal(v, item)
                );
            }*/
        }

        [Fact]
        public void ShouldReturnFullMenu()
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();
            Assert.Equal(16, fullMenu.Count);
            /*
            //entrees
            BriarheartBurger b = new BriarheartBurger();
            DoubleDraugr d = new DoubleDraugr();
            GardenOrcOmelette g = new GardenOrcOmelette();
            PhillyPoacher p = new PhillyPoacher();
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            ThalmorTriple t = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();
            //sides
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            FriedMiraak f = new FriedMiraak();
            MadOtarGrits m = new MadOtarGrits();
            VokunSalad v = new VokunSalad();
            //drinks
            AretinoAppleJuice a = new AretinoAppleJuice();
            CandlehearthCoffee c = new CandlehearthCoffee();
            MarkarthMilk mm = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater w = new WarriorWater();

            Assert.Collection(fullMenu,
                //entrees
                item => Assert.Equal(b, item),
                item => Assert.Equal(d, item),
                item => Assert.Equal(g, item),
                item => Assert.Equal(p, item),
                item => Assert.Equal(s, item),
                item => Assert.Equal(t, item),
                item => Assert.Equal(tb, item),
                //sides
                item => Assert.Equal(dw, item),
                item => Assert.Equal(f, item),
                item => Assert.Equal(m, item),
                item => Assert.Equal(v, item),
                //drinks
                item => Assert.Equal(a, item),
                item => Assert.Equal(c, item),
                item => Assert.Equal(mm, item),
                item => Assert.Equal(ss, item),
                item => Assert.Equal(w, item)
                );

            /*foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                //side sizes
                dw.Size = size;
                f.Size = size;
                m.Size = size;
                v.Size = size;
                //drink sizes
                a.Size = size;
                c.Size = size;
                mm.Size = size;
                ss.Size = size;
                w.Size = size;

                Assert.Collection(fullMenu,
                item => Assert.Equal(dw, item),
                item => Assert.Equal(f, item),
                item => Assert.Equal(m, item),
                item => Assert.Equal(v, item)
                );

                //soda flavor
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    ss.Flavor = sf;
                    Assert.Collection(fullMenu,
                    item => Assert.Equal(ss, item)
                );
                }  */                                 
        }
    }
}
