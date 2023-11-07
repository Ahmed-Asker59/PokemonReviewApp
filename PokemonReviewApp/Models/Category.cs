using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
