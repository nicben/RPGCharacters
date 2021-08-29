using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class Ranger : Hero
    {
        /// <summary>
        /// Creates a hero with the base attributes of  a type ranger 
        /// </summary>
        /// <param name="name"></param>
        public Ranger(string name) : base(name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(8, 1, 7, 1);
        }

        /// <summary>
        /// List with valid weapons for a ranger 
        /// </summary>
        public override List<WeaponType> ValidWeapons => new List<WeaponType> { WeaponType.BOW };

        /// <summary>
        /// List with valid armor for a ranger
        /// </summary>
        public override List<ArmorType> ValidArmor => new List<ArmorType> { ArmorType.LEATHER, ArmorType.MAIL };

        /// <summary>
        /// Level up-method for a ranger
        /// </summary>
        /// <returns></returns>
        public override double GetDamage()
        {
            return 1.0 + (TotalPrimaryAttributes.Dexterity / 100.0);
        }

        public override void LevelUp(int level = 1)
        {
            IsValidLevel(level);

            int vitality = 2;
            int Strength = 1;
            int dexterity = 5;
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
