using RPGCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class HeroClassTests
    {
        [Fact]
        public void Constructer_Mage_ReturnBaseAttributes()
        {
            Mage mage = new("Mage");

            PrimaryAttributes expected = new(5, 1, 1, 8);

            PrimaryAttributes actual = mage.BasePrimaryAttributes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructer_Ranger_ReturnBaseAttributes()
        {
            Ranger ranger = new("Ranger");

            PrimaryAttributes expected = new(8, 1, 7, 1);

            PrimaryAttributes actual = ranger.BasePrimaryAttributes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructer_Rogue_ReturnBaseAttributes()
        {
            Rogue rogue = new("Rogue");

            PrimaryAttributes expected = new(8, 2, 6, 1);

            PrimaryAttributes actual = rogue.BasePrimaryAttributes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructer_Warrior_ReturnBaseAttributes()
        {
            Warrior warrior = new("Warrior");

            PrimaryAttributes expected = new(10, 5, 2, 1);

            PrimaryAttributes actual = warrior.BasePrimaryAttributes;

            Assert.Equal(expected, actual);
        }
    }
}
