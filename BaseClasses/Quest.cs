using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine
{
    public class Quest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            Id = id;
            Name = name;
            Description = description;
            RewardExperience = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
