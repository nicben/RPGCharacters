using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class WeaponAttributes
    {
        public int Damage { get; set; }
        public double AttackSpeed { get; set; }

        /// <summary>
        /// Creates a set of weapon attributes
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="attackSpeed"></param>
        public WeaponAttributes(int damage, double attackSpeed)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        /// <summary>
        /// Method for getting the weapons DPS
        /// </summary>
        /// <returns></returns>
        public double WeaponDPS()
        {
            return Damage * AttackSpeed;
        }
    }
}
