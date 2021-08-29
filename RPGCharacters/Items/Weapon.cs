using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public enum WeaponType
    {
        AXE,
        BOW,
        DAGGER,
        HAMMER,
        STAFFER,
        SWORD,
        WAND
    }
    public class Weapon : Item
    {
        /// <summary>
        /// Defines the weapon type
        /// </summary>
        public WeaponType WeaponType { get; set; }

        /// <summary>
        /// Defines the weapons attributes
        /// </summary>
        public WeaponAttributes WeaponAttributes { get; set; }

        /// <summary>
        /// Creates a new weapon
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="weaponType"></param>
        /// <param name="weaponAttributes"></param>
        public Weapon(string name, int level, WeaponType weaponType, WeaponAttributes weaponAttributes) : base(name, level, Slot.WEAPON)
        {
            WeaponType = weaponType;
            WeaponAttributes = weaponAttributes;
        } 
    }
}
