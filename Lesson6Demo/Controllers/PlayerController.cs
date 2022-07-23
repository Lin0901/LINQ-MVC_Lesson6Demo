using Lesson6Demo.Models;
using Lesson6Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6Demo.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            PlayersAndEquipments pe = new PlayersAndEquipments (Database.PlayerCharacterList,Database.EquipmentList);

            return View(pe);
        }
        public IActionResult GroupByExample()
        {
            //这是列出所有类型
            //var groupedItems = Database.EquipmentList.GroupBy(x => x.Type);
            //这是列出所有 力量属性 > 0 的组合
            //var groupedItems = Database.EquipmentList.GroupBy(e => e.StrengthModifier > 0);
            // OrderBy 是升序
            var groupedItems = Database.EquipmentList.OrderBy(e => e.StrengthModifier).GroupBy(e => e.StrengthModifier > 0);
            return View(groupedItems);
        }
        public IActionResult PlayersGroupBy()
        {
            var groupedPlayers = Database.PlayerCharacterList.GroupBy(p => p.Region);
            return View(groupedPlayers);
        }
        public IActionResult EquipmentGroupBy()
        {
            var groupedEquipment = Database.EquipmentList.OrderBy(e => e.Name).GroupBy(e => e.Name.Substring(0,1));
            return View();
        }
    }
}
