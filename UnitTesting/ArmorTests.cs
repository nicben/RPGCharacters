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
    public class ArmorTests
    {
        [Fact]
        public void Equip_HighLeveledArmor_ThrowInvalidArmorException()
        {
            Warrior warrior = new("Warrior");

            string name = "Plate";
            int level = 2;
            Slot slot = Slot.BODY;
            ArmorType type = ArmorType.PLATE;
            PrimaryAttributes attributes = new()  {Vitality = 2, Strength = 1 };
            

            Armor plate = new(name, level, slot, type, attributes);

            Assert.Throws<InvalidArmorException>(() => warrior.Equip(plate));
        }

        [Fact]
        public void Equip_InvalidArmor_ThrowInvalidArmorException()
        {
            Warrior warrior = new("Warrior");

            string name = "Cloth";
            int level = 1;
            Slot slot = Slot.HEAD;
            ArmorType type = ArmorType.CLOTH;
            PrimaryAttributes attributes = new() { Vitality = 2, Intelligence = 5 };


            Armor cloth = new(name, level, slot, type, attributes);

            Assert.Throws<InvalidArmorException>(() => warrior.Equip(cloth));
        }

        [Fact]
        public void Equip_ValidWeapon_ReturnSuccessMessage()
        {
            Warrior warrior = new("Warrior");
            string expected = "New armor equipped!";

            string name = "Plate";
            int level = 1;
            Slot slot = Slot.BODY;
            ArmorType type = ArmorType.PLATE;
            PrimaryAttributes attributes = new() { Vitality = 2, Strength = 1 };

            Armor plate = new(name, level, slot, type, attributes);

            string actual = warrior.Equip(plate);

            Assert.Equal(expected, actual);
        }

    }
}
