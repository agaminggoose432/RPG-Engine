using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Creature
    {
        public Player(int currentHP, int maxHP, int gold, int experience, int level ) : base(currentHP, maxHP)
        {
            Gold = gold;
            Experience = experience;
            Level = level;
        }

        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

    }
}
