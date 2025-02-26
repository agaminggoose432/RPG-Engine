using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public HealingPotion(int id, string name, string description, string pluralName, int regenAmount) : base(id, name, description, pluralName)
        {
            RegenAmount = regenAmount;
        }

        public int RegenAmount { get; set; }
    }
}
