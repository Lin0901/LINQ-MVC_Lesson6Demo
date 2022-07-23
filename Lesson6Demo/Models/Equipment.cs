namespace Lesson6Demo.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StrengthRequirement { get; set; } // 力量需求
        public int StrengthModifier { get; set; } // 力量修改
        public int IntelligenceRequirement { get; set; } // 智力需求
        public int IntelligenceModifier { get; set; } // 智力修改
        public EquipmentType Type { get; set; } // 装备类型
        public List<PlayerCharacter> Characters { get; set; }  // 多 角色 as many as want
        
        public Equipment(string name, int strengthRequirement, int strengthModifier, 
                         int intelligenceReqiuirement, int intelligenceModifier, EquipmentType type)
        {
            Id = Database.IdCount++;
            Name = name;
            StrengthRequirement = strengthRequirement;          // 可以写成简写 strreq
            StrengthModifier = strengthModifier;                // 可以写成简写 strmod
            IntelligenceModifier = intelligenceModifier;        // 可以写成简写 intmod
            IntelligenceRequirement = intelligenceReqiuirement; // 可以写成简写 intreq
            Type = type;
            Characters = new List<PlayerCharacter>();
        }


    }



    public enum EquipmentType    // enum 枚举 举例
    {
        Armour, // 盔甲
        Weapon, // 武器
        Ring    // 戒指
    }
    
}
