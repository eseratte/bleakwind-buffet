﻿/*
 * Author: Zachery Brunner
 * Modified: Ethan Seratte
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(c);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", cc.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", cc.SpecialInstructions);
            //else Assert.Empty(cc.SpecialInstructions);

            if (includeCream == false && includeIce == false) Assert.Empty(cc.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            cc.Decaf = decaf;
            Assert.Equal(name, cc.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Ice", () =>
            {
                c.Ice = true;
            });
            Assert.PropertyChanged(c, "Ice", () =>
            {
                c.Ice = false;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Decaf", () =>
            {
                c.Decaf = true;
            });
            Assert.PropertyChanged(c, "Decaf", () =>
            {
                c.Decaf = false;
            });
        }

        [Fact]
        public void ChangingCreamNotifiesCreamProperty()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "RoomForCream", () =>
            {
                c.RoomForCream = true;
            });
            Assert.PropertyChanged(c, "RoomForCream", () =>
            {
                c.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Size", () =>
            {
                c.Size = Size.Small;
            });
            Assert.PropertyChanged(c, "Size", () =>
            {
                c.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Size", () =>
            {
                c.Size = Size.Large;
            });
        }
    }
}
