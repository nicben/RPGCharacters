using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    public enum Slot
    {
        HEAD,
        BODY,
        LEGS,
        WEAPON
    }
    public abstract class Item
    {
        /// <summary>
        /// name of item
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Required level for equipping item
        /// </summary>
        public int RequiredLevel { get; set; }
        
        /// <summary>
        /// Defines the slot for each item
        /// </summary>
        public Slot Slot { get; set; }

        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="slot"></param>
        protected Item(string name, int level, Slot slot)
        {
            ItemName = name;
            RequiredLevel = level;
            Slot = slot;
        }
    }

}
