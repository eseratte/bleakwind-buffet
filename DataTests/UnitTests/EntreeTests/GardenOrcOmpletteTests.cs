/*
 * Author: Zachery Brunner
 * Modified: Ethan Seratte
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(g);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(g);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.True(o.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.True(o.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.True(o.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.True(o.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            o.Broccoli = true;
            Assert.True(o.Broccoli);
            o.Broccoli = false;
            Assert.False(o.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            o.Mushrooms = true;
            Assert.True(o.Mushrooms);
            o.Mushrooms = false;
            Assert.False(o.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            o.Tomato = true;
            Assert.True(o.Tomato);
            o.Tomato = false;
            Assert.False(o.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            o.Cheddar = true;
            Assert.True(o.Cheddar);
            o.Cheddar = false;
            Assert.False(o.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.Equal(4.57, o.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.Equal((uint)404, o.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms, bool includeTomato, bool includeCheddar)
        {
            bool b = false;
            GardenOrcOmelette o = new GardenOrcOmelette();
            o.Broccoli = includeBroccoli;
            o.Mushrooms = includeMushrooms;
            o.Tomato = includeTomato;
            o.Cheddar = includeCheddar;

            if (!includeBroccoli)
            {
                Assert.Contains("Hold broccoli", o.SpecialInstructions);
                b = true;
            }

            if (!includeMushrooms)
            {
                Assert.Contains("Hold mushrooms", o.SpecialInstructions);
                b = true;
            }

            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", o.SpecialInstructions);
                b = true;
            }

            if (!includeCheddar)
            {
                Assert.Contains("Hold cheddar", o.SpecialInstructions);
                b = true;
            }

            if (b == false) Assert.Empty(o.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette o = new GardenOrcOmelette();
            Assert.True("Garden Orc Omelette" == o.ToString());
        }
    }
}