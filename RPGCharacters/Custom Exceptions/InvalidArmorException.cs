using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters.Custom_Exceptions
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        /// <summary>
        /// Creates InvalidArmorException 
        /// </summary>
        /// <param name="message"></param>
        public InvalidArmorException(string message) : base(message)
        {

        }

    }
}
