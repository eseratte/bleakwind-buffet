﻿/*
 * Author: Zachery Brunner
 * Modified: Ethan Seratte
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(s);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(s);
        }


        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint)602, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg, bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            bool b = false;
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;

            if (!includeSausage)
            {
                Assert.Contains("Hold sausage", ss.SpecialInstructions);
                b = true;
            }

            if (!includeEgg)
            {
                Assert.Contains("Hold eggs", ss.SpecialInstructions);
                b = true;
            }

            if (!includeHashbrowns)
            {
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);
                b = true;
            }

            if (!includePancake)
            {
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
                b = true;
            }

            if (b == false) Assert.Empty(ss.SpecialInstructions);
        }

    [Fact]
        public void ShouldReturnCorrectToString()
        {
        SmokehouseSkeleton ss = new SmokehouseSkeleton();
        Assert.True("Smokehouse Skeleton" == ss.ToString());
        }

        [Fact]
        public void ChangingSausageNotifiesSausageProperty()
        {
            var s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "SausageLink", () =>
            {
                s.SausageLink = true;
            });
            Assert.PropertyChanged(s, "SausageLink", () =>
            {
                s.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = true;
            });
            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = false;
            });
        }

        [Fact]
        public void ChangingHashbrownsNotifiesHashbrownsProperty()
        {
            var s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Hashbrowns", () =>
            {
                s.HashBrowns = true;
            });
            Assert.PropertyChanged(s, "Hashbrowns", () =>
            {
                s.HashBrowns = false;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Pancake", () =>
            {
                s.Pancake = true;
            });
            Assert.PropertyChanged(s, "Pancake", () =>
            {
                s.Pancake = false;
            });
        }
    }
}