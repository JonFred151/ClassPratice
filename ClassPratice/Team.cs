using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPratice
{
    internal class Team
    {
        public string TrainerName { get; set; }
        public string[] PokeName {  get; set; }
        public string stadium {  get; set; } 
        public double round {  get; set; }  

        public void Draft(string PokemonName, string PokeTrainer)
        {
            Console.WriteLine($"{PokemonName} has been chosen by {PokeTrainer}");
        }

        public void match()
        {
            Console.WriteLine($" Trainer {TrainerName} is playing at {stadium} and the is round {round} using {PokeName}");
        }
    }
}
