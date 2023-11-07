using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string Gym { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
