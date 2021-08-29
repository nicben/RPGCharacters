using RPGCharacters.Custom_Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public abstract class Hero
    {
        /// <summary>
        /// Name of hero
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Heros level
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// List for valid weapontypes
        /// </summary>
        abstract public List<WeaponType> ValidWeapons { get; }

        /// <summary>
        /// List for valid armortypes
        /// </summary>
        abstract public List<ArmorType> ValidArmor { get; }

        /// <summary>
        /// Equipped items
        /// </summary>
        public Dictionary<Slot, Item> EquippedItems = new();

        /// <summary>
        /// Base attributes for hero
        /// </summary>
        public PrimaryAttributes BasePrimaryAttributes { get; set; } = new();

        /// <summary>
        /// Total attributes, the base attributes for hero and armor attributes combined
        /// </summary>
        public PrimaryAttributes TotalPrimaryAttributes
        {
            get
            {
                foreach (KeyValuePair<Slot, Item> item in EquippedItems)
                {
                    if(item.Key != Slot.WEAPON && item.Value != null)
                    {
                        BasePrimaryAttributes += ((Armor)item.Value).ArmorAttributes;
                    }
                }

                return BasePrimaryAttributes;
            }
        }

        /// <summary>
        /// Total secondary attributes
        /// </summary>
        public SecondaryAttributes SecondaryAttributes => new(TotalPrimaryAttributes);


        /// <summary>
        /// Constructer with level 1
        /// </summary>
        /// <param name="name"></param>
        protected Hero(string name)
        {
            Name = name;
            Level = 1;
        }

        /// <summary>
        /// Method for levelling up
        /// </summary>
        /// <param name="level"></param>
        abstract public void LevelUp(int level);

        /// <summary>
        /// Method for getting total damage
        /// </summary>
        /// <returns></returns>
        abstract public double GetDamage();

        /// <summary>
        /// Method for checking if param level is valid
        /// </summary>
        /// <param name="level"></param>
        public void IsValidLevel(int level)
        {
            if (level < 1)
            {
                throw new ArgumentException("Invalid level");
            }
            Level += level;
        }

        /// <summary>
        /// Method for equipping a weapon
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        public string Equip(Weapon weapon)
        {
            if (!ValidWeapons.Contains(weapon.WeaponType)) 
            {
                throw new InvalidWeaponException("Invalid weapon type");
            }
            else if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException("Required level is not met");
            }

            EquippedItems[weapon.Slot] = weapon;

            return "New weapon equipped!";
        }

        /// <summary>
        /// Method for equipping a armor
        /// </summary>
        /// <param name="armor"></param>
        /// <returns></returns>
        public string Equip(Armor armor)
        {
            if (!ValidArmor.Contains(armor.ArmorType))
            {
                throw new InvalidArmorException("Invalid armor type");
            }
            else if (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException("Required level is not met");
            }

            EquippedItems[armor.Slot] = armor;

            return "New armor equipped!";
        }

        /// <summary>
        /// Method for getting total DPS
        /// </summary>
        /// <returns></returns>
        public double GetDPS()
        {
            bool keyExists = EquippedItems.ContainsKey(Slot.WEAPON);
            if (keyExists)
            {
                Weapon weapon = (Weapon)EquippedItems[Slot.WEAPON];
                return  weapon.WeaponAttributes.WeaponDPS() * GetDamage();
            }
            else 
            {
                return 1 * GetDamage();
            }
        }

        /// <summary>
        /// Overriding the ToString-method to show the stats
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return
                $"Name: {Name} (Type: {this.GetType().Name})\n" +
                $"Level: {Level}\n" +
                $"Strength: {TotalPrimaryAttributes.Strength}\n" +
                $"Dexterity: {TotalPrimaryAttributes.Dexterity}\n" +
                $"Intelligence: {TotalPrimaryAttributes.Intelligence}\n" +
                $"Vitality: {TotalPrimaryAttributes.Vitality}\n" +
                $"Health: {SecondaryAttributes.Health}\n" +
                $"Armor Rating: {SecondaryAttributes.ArmorRating}\n" +
                $"Elemental Resistance: {SecondaryAttributes.ElementalResistance}\n" +
                $"DPS: {GetDPS()}";
        }
    }
}
