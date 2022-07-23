namespace Lesson6Demo.Models
{
    public class PlayerCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseHealth { get; set; } // 基础生命值
        public Region Region { get; set; } // 地区
        public int Strength { get; set; } // 武力值
        public int Intelligence { get; set; } // 智力值
        public List<Equipment> Equipment { get; set; }

        public  PlayerCharacter(string name, int baseHealth, int strength, int intelligence, Region region)
        {
            Id = Database.IdCount++;
            Name = name;
            BaseHealth = baseHealth;
            Strength = strength;
            Intelligence = intelligence;
            Region = region;
            Equipment = new List<Equipment>();
        }
    }
    public enum Region
    {
        Asia,
        North_America,
        South_America,
        Europe,
        Africa
    }
}
