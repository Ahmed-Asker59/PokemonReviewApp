using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; }
    }
}
