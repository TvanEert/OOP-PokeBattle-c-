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

        //Constructor
        public Pokemon(string Name, string EnergyType, int MaxHP, int HP)
        {
            this.Name = Name;
            this.EnergyType = EnergyType;
            this.MaxHP = MaxHP;
            this.HP = HP;
            CalcWeakness();
            CalcResistance();
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
        }
    }
}
