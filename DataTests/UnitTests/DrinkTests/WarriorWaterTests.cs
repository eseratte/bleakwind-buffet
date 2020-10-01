/*
 * Author: Ethan Seratte
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(w);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (includeIce == false) Assert.Contains("Hold ice", ww.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            
            if(includeIce == true && includeLemon == false) Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var w = new WarriorWater();
            Assert.PropertyChanged(w, "Ice", () =>
            {
                w.Ice = true;
            });
            Assert.PropertyChanged(w, "Ice", () =>
            {
                w.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var w = new WarriorWater();
            Assert.PropertyChanged(w, "Lemon", () =>
            {
                w.Lemon = true;
            });
            Assert.PropertyChanged(w, "Lemon", () =>
            {
                w.Lemon = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var w = new WarriorWater();
            Assert.PropertyChanged(w, "Size", () =>
            {
                w.Size = Size.Small;
            });
            Assert.PropertyChanged(w, "Size", () =>
            {
                w.Size = Size.Medium;
            });
            Assert.PropertyChanged(w, "Size", () =>
            {
                w.Size = Size.Large;
            });
        }
    }
}
