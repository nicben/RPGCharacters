using RPGCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class DPSTests
    {

        [Fact]
        public void GetDPS_NoWeaponEquipped_ReturnWithoutWeaponDPS()
        {
            Warrior warrior = new("Warrior");

            double expected = 1.0 * (1.0 + (5.0 / 100.0));
            double actual = warrior.GetDPS();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDPS_WithValidWeaponEquipped_ReturnWithWeaponDPS()
        {
            Warrior warrior = new("Warrior");

            string name = "Axe";
            int level = 1;
            WeaponType type = WeaponType.AXE;
            WeaponAttributes attributes = new(7, 1.1);
            Weapon axe = new(name, level, type, attributes);
            warrior.Equip(axe);

            double expected = (7.0 * 1.1) * (1.0 + (5.0 / 100.0));
            double actual = warrior.GetDPS();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDP_WithValidWeaponAndArmorEquipped_ReturnTotalDPS()
        {
            Warrior warrior = new("Warrior");

            string wName = "Axe";
            int wLevel = 1;
            WeaponType wType = WeaponType.AXE;
            WeaponAttributes wAttributes = new(7, 1.1);
            Weapon axe = new(wName, wLevel, wType, wAttributes);
            warrior.Equip(axe);

            string aName = "Plate";
            ArmorType aType = ArmorType.PLATE;
            Slot slot = Slot.BODY;
            PrimaryAttributes aAttributes = new() { Strength = 1, Vitality = 2 };
            int aLevel = 1;
            Armor plate = new(aName, aLevel, slot, aType, aAttributes);
            warrior.Equip(plate);

            double expected = (7.0 * 1.1) * (1.0 + ((5.0 + 1.0) / 100.0));
     
            double actual = warrior.GetDPS();

            Assert.Equal(expected, actual);
        }

    }
}
