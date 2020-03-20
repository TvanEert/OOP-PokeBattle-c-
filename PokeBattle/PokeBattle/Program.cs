using System;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon Femke = new Pokemon("Femke", "Water", 17, 8);

            Femke.DisplayStats();
            Console.Read();
        }
    }
}
