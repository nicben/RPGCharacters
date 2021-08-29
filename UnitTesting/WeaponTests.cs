using RPGCharacters;
using RPGCharacters.Custom_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class WeaponTests
    {
        [Fact]
        public void Equip_HighLeveledWeapon_ThrowInvalidWeaponException()
        {
            Warrior warrior = new("Warrior");

            string name = "Axe";
            WeaponType type = WeaponType.AXE;
            WeaponAttributes attributes = new(10, 1.1);
            int level = 2;

            Weapon axe = new(name, level, type, attributes);

            Assert.Throws<InvalidWeaponException>(() => warrior.Equip(axe));
        }

        [Fact]
        public void Equip_InvalidWeapon_ThrowInvalidWeaponException()
        {
            Warrior warrior = new("Warrior");

            string name = "Bow";
            WeaponType type = WeaponType.BOW;
            WeaponAttributes attributes = new(6, 1.1);
            int level = 1;

            Weapon bow = new(name, level, type, attributes);

            Assert.Throws<InvalidWeaponException>(() => warrior.Equip(bow));
        }

        [Fact]
        public void Equip_ValidWeapon_ReturnSuccessMessage()
        {
            Warrior warrior = new("Warrior");
            string expected = "New weapon equipped!";

            string name = "Sword";
            WeaponType type = WeaponType.SWORD;
            WeaponAttributes attributes = new(6, 1.2);
            int level = 1;
            Weapon sword = new(name, level, type, attributes);

            string actual = warrior.Equip(sword);

            Assert.Equal(expected, actual);
        }
    }
}
