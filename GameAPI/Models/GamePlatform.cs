using System.ComponentModel.DataAnnotations.Schema;

namespace GameAPI.Models
{
    [Table("game_platform")]
    // Modèle de la liaison Game/Platform
    public class GamePlatform
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
