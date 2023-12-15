using System;
namespace ClassPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            var Worlds = new Team();

            Worlds.TrainerName = "Wolfe";
            Worlds.PokeName = new string[]  { "Pikachu" };
            Worlds.stadium = "Orlando";
            Worlds.round = 2;
            Worlds.Draft("Pikachu", "Wolfe");

            Worlds.match();


        }
    }

}