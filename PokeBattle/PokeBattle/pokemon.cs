using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Pokemon
    {
        //Properties
        public string Name { get; }
        public string EnergyType { get; }
        public int MaxHP { get; }
        public int HP { get; set; }
        public string Weakness { get; set; }
        private double MultiplierWeak = 1.2;
        public string Resistance { get; set; }
        private double MultiplierRes = 0.8;
        public List<Attack> Attacks = new List<Attack>();

        //Constructor
        public Pokemon(string Name, string EnergyType, int MaxHP, int HP)
        {
            this.Name = Name;
            this.EnergyType = EnergyType;
            this.MaxHP = MaxHP;
            this.HP = HP;
            CalcWeakness();
            CalcResistance();
            SetAttacks();
        }

        //Methods
        private void CalcWeakness()
        {
            switch (EnergyType)
            {
                case "Fire":
                    this.Weakness = "Water";
                    break;
                case "Water":
                    this.Weakness = "Grass";
                    break;
                case "Grass":
                    this.Weakness = "Fire";
                    break;
            }
        }

        private void CalcResistance()
        {
            switch (EnergyType)
            {
                case "Fire":
                    this.Resistance = "grass";
                    break;
                case "Grass":
                    this.Resistance = "Water";
                    break;
                case "Water":
                    this.Resistance = "Fire";
                    break;
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine(EnergyType);
            Console.WriteLine(MaxHP);
            Console.WriteLine(HP);
            Console.WriteLine(Weakness);
            Console.WriteLine(Resistance);
            Console.WriteLine(Attacks[0].Name);
            Console.WriteLine(Attacks[1].Name);
        }

        public void SetAttacks()
        {
            Attack BlazeKick = new Attack("Blaze Kick", 85);
            Attack FirePunch = new Attack("Fire Punch", 75);
            Attack HydroPump = new Attack("Hydro Pump", 110);
            Attack Waterfall = new Attack("Waterfall", 80);
            Attack LeafBlade = new Attack("Leaf Blade", 90);
            Attack SeedBomb = new Attack("Seed Bomb", 80);


            switch (EnergyType)
            {
                case "Fire":
                    Attacks.Add(BlazeKick);
                    Attacks.Add(FirePunch);
                    break;
                case "Water":
                    Attacks.Add(HydroPump);
                    Attacks.Add(Waterfall);
                    break;
                case "Grass":
                    Attacks.Add(LeafBlade);
                    Attacks.Add(SeedBomb);
                    break;
            }
        }
    }
}
