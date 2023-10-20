using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class AloeVera : SucculentPlant
    {
        public string HealingEffect { get; set; }
        public AloeVera(string looks, string plantNickname,
        string mostInWhatContinent, string storageOfWater, string healingEffect)
            : base(looks, plantNickname, mostInWhatContinent, storageOfWater)
        {
            HealingEffect = healingEffect;

        }

        public void PrintAloe()
        {

            Console.WriteLine(" \\\\  ||  // //");
            Console.WriteLine("  \\\\ || // //");
            Console.WriteLine("   \\\\||// //");

        }

    }
}