using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Attack
    {
        //Properties
        public string Name { get; }
        public int DamageVal { get; set; }

        //Constructor 
        public Attack(string Name, int DamageVal)
        {
            this.Name = Name;
            this.DamageVal = DamageVal;
        }
    }
}
