using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public class PrimaryAttributes
    {
        public int Vitality { get; set; } = 0;
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Intelligence { get; set; } = 0;

         
        public PrimaryAttributes() { }

        /// <summary>
        /// Creates a set of attributes
        /// </summary>
        /// <param name="vitality"></param>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        public PrimaryAttributes(int vitality, int strength, int dexterity, int intelligence)
        {
            Vitality = vitality;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        /// <summary>
        /// Overriding the Equals-method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is PrimaryAttributes attributes &&
                   Vitality == attributes.Vitality &&
                   Strength == attributes.Strength &&
                   Dexterity == attributes.Dexterity &&
                   Intelligence == attributes.Intelligence;
        }

        /// <summary>
        /// Overriding the GetHashCode-method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Vitality, Strength, Dexterity, Intelligence);
        }

        /// <summary>
        /// Overriding the plus operator for PrimaryAttributes
        /// </summary>
        /// <param name="leftSide"></param>
        /// <param name="rightSide"></param>
        /// <returns></returns>
        public static PrimaryAttributes operator +(PrimaryAttributes leftSide, PrimaryAttributes rightSide) => new()
        {
            Vitality = leftSide.Vitality + rightSide.Vitality,
            Strength = leftSide.Strength + rightSide.Strength,
            Dexterity = leftSide.Dexterity + rightSide.Dexterity,
            Intelligence = leftSide.Intelligence + rightSide.Intelligence
        };

    }
    
}
