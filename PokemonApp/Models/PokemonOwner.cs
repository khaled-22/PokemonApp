﻿namespace PokemonApp.Models
{
    public class PokemonOwner
    {
        public int pokemonId { get; set; }
        public int OwnerId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }


    }
}
