using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class Warrior : Hero
    {

        /// <summary>
        /// Creates a hero with the base attributes of a type warrior 
        /// </summary>
        /// <param name="name"></param>
        public Warrior(string name) : base(name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(10, 5, 2, 1);
        }

        /// <summary>
        /// List with valid weapons for a warrior 
        /// </summary>
        public override List<WeaponType> ValidWeapons => new List<WeaponType> { WeaponType.AXE, WeaponType.HAMMER, WeaponType.SWORD };

        /// <summary>
        /// List with valid armor for a warrior
        /// </summary>
        public override List<ArmorType> ValidArmor => new List<ArmorType> { ArmorType.MAIL, ArmorType.PLATE };

        /// <summary>
        /// Total damage for a warrior
        /// </summary>
        /// <returns></returns>
        public override double GetDamage()
        {
            return 1.0 + (TotalPrimaryAttributes.Strength / 100.0);
        }

        /// <summary>
        /// Level up-method for a warrior
        /// </summary>
        /// <param name="level"></param>
        public override void LevelUp(int level = 1)
        {
            IsValidLevel(level);

            int vitality = 5;
            int Strength = 3;
            int dexterity = 2;
            int intelligence = 1;

            BasePrimaryAttributes += new PrimaryAttributes(
                                                vitality * level,
                                                Strength * level,
                                                dexterity * level,
                                                intelligence * level
                                                );
        }
    }
}
