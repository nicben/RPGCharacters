using System;

namespace RPGCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Lola");
            Console.WriteLine(mage.ToString());
            Console.WriteLine(" ");
            
            mage.LevelUp();
            Console.WriteLine(mage.ToString());
            Console.WriteLine("***************************************************");
            Console.WriteLine(" ");

            Ranger ranger = new Ranger("Peteeeeeeeee");
            Console.WriteLine(ranger.ToString());
            Console.WriteLine(" ");
            
            ranger.LevelUp(1);
            Console.WriteLine(ranger.ToString());
            Console.WriteLine("***************************************************");

            ranger.LevelUp(5);
            Console.WriteLine(ranger.ToString());
            Console.WriteLine("***************************************************");
        }
    }
}
