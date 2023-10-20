using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Cactus : SucculentPlant
    {
        public string Spiny { get; set; }
        public Cactus(string looks, string plantNickname,
        string mostInWhatContinent, string storageOfWater, string spiny)
            : base(looks, plantNickname, mostInWhatContinent, storageOfWater)
        {
            Spiny = spiny;

        }

        public void PrintCactus()
        {
            Console.WriteLine("  _  _");
            Console.WriteLine(" | || | _");
            Console.WriteLine("-| || || |");
            Console.WriteLine(" | || || |-");
            Console.WriteLine(" \\_  || |");
            Console.WriteLine("   |  _/");
            Console.WriteLine("-  | |\\");
            Console.WriteLine("   |_|-");
        }

    }
}
