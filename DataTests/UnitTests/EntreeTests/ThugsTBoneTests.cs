/*
 * Author: Zachery Brunner
 * Modified: Ethan Seratte
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(t);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(t);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal((uint)982, tb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.True("Thugs T-Bone" == tb.ToString());
        }
    }
}