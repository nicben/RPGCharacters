using RPGCharacters;
using System;
using Xunit;

namespace UnitTesting
{
    public class HeroTests
    {
        [Fact]
        public void Constructer_ReturnLevelOne()
        {
            Mage mage = new("Mage");

            int expected = 1;

            int actual = mage.Level;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_ReturnLevelTwo()
        {
            Mage mage = new("Mage");

            mage.LevelUp();

            int expected = 2;

            int actual = mage.Level;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void LevelUp_IvalidLevel_ThrowArgumentException(int value)
        {
            Mage mage = new("Mage");

            Assert.Throws<ArgumentException>(() => mage.LevelUp(value));
        }

    }
}
