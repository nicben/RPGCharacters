using RPGCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class HeroLevelUpTests
    {

        [Fact]
        public void Constructor_CreateAndLevelUpMage_ReturnIncreasedPrimaryAttributes()
        {
            Mage mage = new("Mage");

            PrimaryAttributes startPoint = new(5, 1, 1, 8);
            PrimaryAttributes levelUp = new(3, 1, 1, 5);
            PrimaryAttributes expected = startPoint + levelUp;

            mage.LevelUp();
            PrimaryAttributes actual = mage.TotalPrimaryAttributes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateAndLevelUpRanger_ReturnIncreasedPrimaryAttributes()
        {
            Ranger ranger = new("Ranger");

            PrimaryAttributes startPoint = new(8, 1, 7, 1);
            PrimaryAttributes levelUp = new(2, 1, 5, 1);
            PrimaryAttributes expected = startPoint + levelUp;

            ranger.LevelUp();
            PrimaryAttributes actual = ranger.TotalPrimaryAttributes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateAndLevelUpRogue_ReturnIncreasedPrimaryAttributes()
        {
            Rogue rogue = new("Rogue");

            PrimaryAttributes startPoint = new(8, 2, 6, 1);
            PrimaryAttributes levelUp = new(3, 1, 4, 1);
            PrimaryAttributes expected = startPoint + levelUp;

            rogue.LevelUp();
            PrimaryAttributes actual = rogue.TotalPrimaryAttributes;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Constructor_CreateAndLevelUpWarrior_ReturnIncreasedPrimaryAttributes()
        {
            Warrior warrior = new("Warrior");

            PrimaryAttributes startPoint = new(10, 5, 2, 1);
            PrimaryAttributes levelUp = new(5, 3, 2, 1);
            PrimaryAttributes expected = startPoint + levelUp;

            warrior.LevelUp();
            PrimaryAttributes actual = warrior.TotalPrimaryAttributes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateAndLevelUpWarrior_ReturnIncreasedSecondaryAttributes()
        {
            Warrior warrior = new("Warrior");
            
            PrimaryAttributes startPoint = new(10, 5, 2, 1);
            PrimaryAttributes levelUp = new(5, 3, 2, 1);
            PrimaryAttributes total = startPoint + levelUp;
            SecondaryAttributes expected = new(total);

            warrior.LevelUp();
            SecondaryAttributes actual = warrior.SecondaryAttributes;

            Assert.Equal(expected, actual);
        }

    }

}
