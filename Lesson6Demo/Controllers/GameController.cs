using Lesson6Demo.Models;
using Lesson6Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6Demo.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            // display all characters AND all equipment
            // if you wanna choose any Asia players
            // List<PlayerCharacter> asiaPlayers = Database.PlayerCharacterList.Where(p => p.Region == Region.Asia).ToList();

            PlayersAndEquipments pe = new PlayersAndEquipments(Database.PlayerCharacterList, Database.EquipmentList);

            return View(pe);
        }

        public IActionResult AllEquipment()
        {
            return View(Database.EquipmentList);
        }

        // GET /game/createequipment
        public IActionResult CreateEquipment()
        {
            return View();
        }

        [HttpPost]
        // POST /game/createequipment
        public IActionResult CreateEquipment(string name, int strengthRequirement, int strengthModifier,
                         int intelligenceReqiuirement, int intelligenceModifier, EquipmentType type)
        {
             Equipment newequipment = new Equipment(name,strengthRequirement, strengthModifier, intelligenceReqiuirement, intelligenceModifier, type);
             Database.EquipmentList.Add(newequipment);

             return RedirectToAction("Index"); // 跳转
        }

    }
}
