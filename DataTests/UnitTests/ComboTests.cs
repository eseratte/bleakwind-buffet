/* Author: Ethan Seratte
 * Name: MenuTests.cs
 * Purpose: Test Combo.cs class in the Data library
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
    public class ComboTests
    {
        public void SettingEntreeShouldNotifyEntreeProperties()
        {
            var combo = new Combo();
            var entree = new BriarheartBurger();
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = entree;
            });
        }

        public void SettingSideShouldNotifyEntreeProperties()
        {
            var combo = new Combo();
            var side = new DragonbornWaffleFries();
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = side;
            });
        }

        public void SettingDrinkShouldNotifyDrinkProperties()
        {
            var combo = new Combo();
            var drink = new SailorSoda();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = drink;
            });
        }
    }
}
