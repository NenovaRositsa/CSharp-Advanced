using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Trainer
    {
        public Trainer(string trainerName)
        {
            Name = trainerName;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
