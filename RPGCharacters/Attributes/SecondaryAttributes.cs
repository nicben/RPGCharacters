using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class SecondaryAttributes
    {
        public int Health { get; set; } = 0;
        public int ArmorRating { get; set; } = 0;
        public int ElementalResistance { get; set; } = 0;

        public SecondaryAttributes() { }

        /// <summary>
        /// Total set of secondary attrebutes
        /// </summary>
        /// <param name="totalPrimaryAttributes"></param>
        public SecondaryAttributes(PrimaryAttributes totalPrimaryAttributes)
        {
            Health = totalPrimaryAttributes.Vitality * 10;
            ArmorRating = totalPrimaryAttributes.Dexterity + totalPrimaryAttributes.Strength;
            ElementalResistance = totalPrimaryAttributes.Intelligence;
        }

        /// <summary>
        /// Overriding the Equals-method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is SecondaryAttributes attributes &&
                   Health == attributes.Health &&
                   ArmorRating == attributes.ArmorRating &&
                   ElementalResistance == attributes.ElementalResistance;
        }

        /// <summary>
        /// Overriding the GetHashCode-method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Health, ArmorRating, ElementalResistance);
        }
    }
}
