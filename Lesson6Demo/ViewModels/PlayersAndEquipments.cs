using Lesson6Demo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson6Demo.ViewModels
{
    public class PlayersAndEquipments
    {
        public List<SelectListItem> SelectListItem { get; set; }
        public List<PlayerCharacter> Players { get; set; }
        public List<Equipment> Equipments { get; set; }

        public PlayersAndEquipments(List<PlayerCharacter> players, List<Equipment> equipments)
        {
            Players = players;
            Equipments = equipments;

            SelectListItem = new List<SelectListItem>
            {
                new SelectListItem("Strength","str")
            };
        }
    }

}
