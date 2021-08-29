using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class Rogue : Hero
    {
        /// <summary>
        /// Creates a hero with the base attributes of a type rouge 
        /// </summary>
        public Rogue(string name) : base(name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(8, 2, 6, 1); 
        }

        /// <summary>
        ///List with valid weapons for a rouge 
        /// </summary>
        public override List<WeaponType> ValidWeapons => new List<WeaponType> { WeaponType.DAGGER, WeaponType.SWORD };

        /// <summary>
        /// List with valid armor for a rouge
        /// </summary>
        public override List<ArmorType> ValidArmor => new List<ArmorType> { ArmorType.LEATHER, ArmorType.MAIL };

        /// <summary>
        /// Total damage for a rouge
        /// </summary>
        /// <returns></returns>
        public override double GetDamage()
        {
            return 1.0 + (TotalPrimaryAttributes.Dexterity / 100.0);
        }

        /// <summary>
        /// Level up-method for a rouge
        /// </summary>
        /// <param name="level"></param>
        public override void LevelUp(int level = 1)
        { 
            IsValidLevel(level);

            int vitality = 3;
            int Strength = 1;
            int dexterity = 4;
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
