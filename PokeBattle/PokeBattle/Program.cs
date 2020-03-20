
using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon Femke = new Pokemon("Femke", "Grass", 17, 8);

            Femke.DisplayStats();
            Console.Read();
        }
    }
}