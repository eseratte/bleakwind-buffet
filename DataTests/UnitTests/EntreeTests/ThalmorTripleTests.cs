﻿/*
 * Author: Zachery Brunner
 * Modified: Ethan Seratte
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(t);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(t);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple  tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal((uint)943, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard, bool includePickle, bool includeCheese, bool includeTomato, bool includeLettuce, bool includeMayo, bool includeBacon, bool includeEgg)
        {
            bool b = false;
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (!includeBun)
            {
                Assert.Contains("Hold bun", tt.SpecialInstructions);
                b = true;
            }

            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
                b = true;
            }

            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
                b = true;
            }

            if (!includePickle)
            {
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
                b = true;
            }

            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
                b = true;
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
                b = true;
            }
            if (!includeLettuce)
            {
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
                b = true;
            }
            if (!includeMayo)
            {
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
                b = true;
            }
            if (!includeBacon)
            {
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
                b = true;
            }
            if (!includeEgg)
            {
                Assert.Contains("Hold egg", tt.SpecialInstructions);
                b = true;
            }

            if (b == false) Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True("Thalmor Triple" == tt.ToString());
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Bun", () =>
            {
                t.Bun = true;
            });
            Assert.PropertyChanged(t, "Bun", () =>
            {
                t.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Ketchup", () =>
            {
                t.Ketchup = true;
            });
            Assert.PropertyChanged(t, "Ketchup", () =>
            {
                t.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Mustard", () =>
            {
                t.Mustard = true;
            });
            Assert.PropertyChanged(t, "Mustard", () =>
            {
                t.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Pickle", () =>
            {
                t.Pickle = true;
            });
            Assert.PropertyChanged(t, "Pickle", () =>
            {
                t.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Cheese", () =>
            {
                t.Cheese = true;
            });
            Assert.PropertyChanged(t, "Cheese", () =>
            {
                t.Cheese = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Lettuce", () =>
            {
                t.Lettuce = true;
            });
            Assert.PropertyChanged(t, "Lettuce", () =>
            {
                t.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Tomato", () =>
            {
                t.Tomato = true;
            });
            Assert.PropertyChanged(t, "Tomato", () =>
            {
                t.Tomato = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Egg", () =>
            {
                t.Egg = true;
            });
            Assert.PropertyChanged(t, "Egg", () =>
            {
                t.Egg = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Bacon", () =>
            {
                t.Bacon = true;
            });
            Assert.PropertyChanged(t, "Bacon", () =>
            {
                t.Bacon = false;
            });
        }
    }
}