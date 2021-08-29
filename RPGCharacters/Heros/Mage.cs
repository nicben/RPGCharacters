using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class Mage : Hero
    {
        /// <summary>
        /// Creates a hero with the base attributes of a type mage 
        /// </summary>
        /// <param name="name"></param>
        public Mage(string name) : base(name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(5, 1, 1, 8);
        }

        /// <summary>
        /// List with valid weapons for a mage 
        /// </summary>
        public override List<WeaponType> ValidWeapons => new List<WeaponType> { WeaponType.STAFFER, WeaponType.WAND };

        /// <summary>
        /// List with valid armor for a mage
        /// </summary>
        public override List<ArmorType> ValidArmor => new List<ArmorType> { ArmorType.CLOTH };

        /// <summary>
        /// Total damage for a mage
        /// </summary>
        /// <returns></returns>
        public override double GetDamage()
        {
            return 1.0 + (TotalPrimaryAttributes.Intelligence / 100.0);
        }

        /// <summary>
        /// Level up-method for a mage
        /// </summary>
        /// <param name="level"></param>
        public override void LevelUp(int level = 1)
        {
            IsValidLevel(level);

            int vitality = 3;
            int Strength = 1;
            int dexterity = 1;
            int intelligence = 5;

            BasePrimaryAttributes += new PrimaryAttributes(
                                                vitality * level, 
                                                Strength * level, 
                                                dexterity * level, 
                                                intelligence * level
                                                );
        }
    }
}
