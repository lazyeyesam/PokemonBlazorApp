using System.ComponentModel.DataAnnotations;

namespace PokemonBlazorApp.Data
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [Range(1, 600, ErrorMessage = "Total must be between 1 and 600")]
        public int Total { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "HP must be between 1 and 200")]
        public int HP { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Attack must be between 1 and 200")]
        public int Attack { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Defence must be between 1 and 200")]
        public int Defence { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Speed must be between 1 and 200")]
        public int Speed { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Generation must be between 1 and 200")]
        public int Generation { get; set; }

        [Required]
        public bool Legendary { get; set; }

        public List<Trainer> Trainers { get; set; }
    }
}
