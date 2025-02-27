using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> items = new List<Item>();
        public static readonly List<BasicEnemy> enemies = new List<BasicEnemy>();
        public static readonly List<Quest> quests = new List<Quest>();
        public static readonly List<Location> locations = new List<Location>();

        // Put all IDs for items, enemies, quest and locations here

        // Item IDs
        public const int basicSwordId = 0;
        public const int healingPotionId = 1;
        public const int boneId = 2;
        public const int shortSwordId = 3;
        public const int clubId = 4;
        public const int shieldId = 5;
        public const int alchemistSwordId = 6;

        // Creature IDs
        public const int skeletonId = 0;
        public const int zombieId = 1;
        public const int alcehmistId = 2;
        public const int ogreId = 3;
        public const int alchemistUnderling = 4;

        // Quest IDs
        public const int killZombiesId = 0;
        public const int killSkeletonsId = 1;
        public const int alcehmistBossId = 2;
        public const int completeDungeon = 3;

        // Location IDs
        public const int homeId = 0;
        public const int townSqaureId = 1;
        public const int dungeonEntranceId = 2;
        public const int cryptId = 3;
        public const int dungeonLootRoomId = 4;
        public const int alchemistTowerId = 5;
        public const int alchemistLabId = 6;
        public const int caveId = 7;

        static World()
        {
            AddItems();
            AddEnemies();
            AddQuests();
        }

        private static void AddItems()
        {
            items.Add(new Weapon(basicSwordId, "Wooden sword", "A sword designed for kids to play with", null, 5, 1));
            items.Add(new HealingPotion(healingPotionId, "Healing potion", "A strange potion capable of regenerating your health", "Healing potions", 6));
            items.Add(new Item(boneId, "Bone", "A bone from a corpse", "Bones"));
            items.Add(new Weapon(shortSwordId, "Short sword", "A proper sword designed to kill", null, 15, 5));
            items.Add(new Weapon(clubId, "Club", "A large club used by an ogre", "Clubs", 7, 4));
            items.Add(new Weapon(alchemistSwordId, "Alchemist's sword", "A powerful sword used by the head alchemist", null, 20, 10));
        }

        private static void AddEnemies()
        {
            BasicEnemy skeleton = new BasicEnemy(5, 5, skeletonId, "Skeleton", 3, 5, 2);
            skeleton.LootTable.Add(new LootItem(ItemByID(boneId), 50, false));
            BasicEnemy zombie = new BasicEnemy(10, 10, zombieId, "Zombie", 5, 10, 10);
            zombie.LootTable.Add(new LootItem(ItemByID(boneId), 25, false));
            BasicEnemy alchemistBoss = new BasicEnemy(30, 30, alcehmistId, "The alchemist", 10, 50, 100);
            alchemistBoss.LootTable.Add(new LootItem(ItemByID(healingPotionId), 100, false));
            alchemistBoss.LootTable.Add(new LootItem(ItemByID(alchemistSwordId), 100, false));
            BasicEnemy ogreBoss = new BasicEnemy(40, 40, ogreId, "Ogre", 7, 25, 40);
            ogreBoss.LootTable.Add(new LootItem(ItemByID(clubId), 50, false));
            BasicEnemy underling = new BasicEnemy(10, 10, alchemistUnderling, "Alchemist underling", 5, 15, 25);
            underling.LootTable.Add(new LootItem(ItemByID(healingPotionId), 50, false));
        }

        private static void AddQuests()
        {
            Quest killZombies = new Quest(killZombiesId, "Kill zombies", "Kill 5 zombies found in the dungeon", 50, 100);
            Quest killSkeletons = new Quest(killSkeletonsId, "Kill skeletons", "Kill 5 skeletons found in the dungeon", 40, 75);
            Quest clearDungeon = new Quest(completeDungeon, "Complete the dungeon", "Make it all the way though the dungeon", 100, 150);
            clearDungeon.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(shortSwordId), 1));
            Quest killAlchemist = new Quest(alcehmistBossId, "Kill the alchemist", "Kill the wicked alchemist at his tower", 200, 200);
            quests.Add(killAlchemist);
            quests.Add(killSkeletons);
            quests.Add(clearDungeon);
            quests.Add(killZombies);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static BasicEnemy EnemyByID(int id)
        {
            foreach (BasicEnemy enemy in enemies)
            {
                if (enemy.Id == id)
                {
                    return enemy;
                }
            }
            return null;
        }
        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in quests)
            {
                if (quest.Id == id)
                {
                    return quest;
                }
            }
            return null;
        }
        public static Location LocationByID(int id)
        {
            foreach (Location location in locations)
            {
                if (location.Id == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
