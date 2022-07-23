namespace Lesson6Demo.Models
{
    public static class Database // 将他变成 static 模式，意味着 只有一个。 Only one
    {
        // 把两大 Model 的集合都写到 Database里
        public static List<Equipment> EquipmentList { get; set; }
        public static List<PlayerCharacter> PlayerCharacterList { get; set; }

        public static int IdCount = 0;
        static Database()
        {
            EquipmentList = new List<Equipment>()
            {
                new Equipment("Weapon1",3,2,0,2,EquipmentType.Weapon),
                new Equipment("Weapon2",0,4,12,20,EquipmentType.Weapon),
                new Equipment("Weapon3",-1,3,20,25,EquipmentType.Weapon),

                new Equipment("Armour1",4,10,0,0,EquipmentType.Armour),
                new Equipment("Armour2",3,8,3,8,EquipmentType.Armour),
                new Equipment("Armour3",20,30,-4,4,EquipmentType.Armour),

                new Equipment("Ring1",2,3,6,4,EquipmentType.Ring),
                new Equipment("Ring2",12,30,16,-12,EquipmentType.Ring),
                new Equipment("Ring3",-2,0,26,4,EquipmentType.Ring),
        };

            PlayerCharacterList = new List<PlayerCharacter>() 
            {
                new PlayerCharacter("Ann",100,40,80,Region.Africa),
                new PlayerCharacter("Bill",800,20,120,Region.South_America),
                new PlayerCharacter("James",200,100,20,Region.North_America),
                new PlayerCharacter("Lee",100,80,200,Region.Asia),
            };
        }
    }
}
