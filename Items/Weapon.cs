using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public Weapon(int id, string name, string description, string pluralName, int maxDamage, int minDamage) : base(id, name, description, pluralName)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }

        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
    }
}
