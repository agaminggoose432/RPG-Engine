using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BasicEnemy : Creature
    {
        public BasicEnemy(int currentHP, int maxHP, int id, string name, int maxDamage, int rewardExperience, int rewardGold) : base(currentHP, maxHP)
        {
            Id = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
    }
}
