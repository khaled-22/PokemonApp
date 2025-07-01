namespace PokemonApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Betyr at en person kan være fra mange land
        public ICollection<Owner> Owners { get; set; }

    }
}
