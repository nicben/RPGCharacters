using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public enum ArmorType
    {
        CLOTH,
        LEATHER,
        MAIL,
        PLATE
    }
    public class Armor : Item
    {
        /// <summary>
        /// Defines the armer type
        /// </summary>
        public ArmorType ArmorType { get; set; }

        /// <summary>
        /// Defines the armors attributes
        /// </summary>
        public PrimaryAttributes ArmorAttributes { get; set; }

        /// <summary>
        /// Creates a new armor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="slot"></param>
        /// <param name="armorType"></param>
        /// <param name="armorAttributes"></param>
        public Armor(string name, int level, Slot slot, ArmorType armorType, PrimaryAttributes armorAttributes) : base(name, level, slot)
        {
            ArmorType = armorType;
            ArmorAttributes = armorAttributes;
        }
    }
}
