using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAPI.Models
{
    [Table("games")]
    // Modèle de la table games
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Editor { get; set; }
        public decimal Rate { get; set; }
        public int NbRates { get; set; }

        public ICollection<GamePlatform> GamePlatforms { get; set; }

        [NotMapped]
        public ICollection<Platform> Platforms 
        { 
            get 
            {
                return GamePlatforms != null ? new List<Platform>(GamePlatforms.Select(gp => gp.Platform)) : new List<Platform>();
            } 
        }
    }
}
