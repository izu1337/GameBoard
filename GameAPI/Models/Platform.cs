using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace GameAPI.Models
{
    [Table("platforms")] 
    // Modèle de la table platform
    public class Platform
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<GamePlatform> GamePlatforms { get; set; }
    }
}
