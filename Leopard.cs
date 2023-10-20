using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    internal class Leopard : Cat
    {
        internal string Fast { get; set; }

        internal Leopard(string colorPattern, string gender, string nickname,
        int populationWorldWide, string mostInWhatCountry, string elasticity, string fast)
        : base(colorPattern, gender, nickname, populationWorldWide, mostInWhatCountry, elasticity)
        {
            Fast = fast;
        }

        public void RunsExtraFast()
        {
            Console.WriteLine("Damn it's fast!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("the leopard makes rasping calls \nsounding like sawing through coarse wood");
        }
        public override void Runs()
        {
            Console.WriteLine("The leopard is fast, the fastest");
        }
        public override void Eat()
        {
            Console.WriteLine("leopards eat antelopes");
        }



        public void PrintLeopard()
        {
            Console.WriteLine("(\"`-''-/\").___..--''\"`-._");
            Console.WriteLine("`6_ 6  )o 0 o`-.  (  o 0 o).`-.__.`)");
            Console.WriteLine("(_Y_.)'o 0._o 0 o)  `._ `. ``-..-'");
            Console.WriteLine("_..`--'_..-_/  /--'_.'");
            Console.WriteLine("((((.-''  ((((.'  (((.-'");

        }
    }
}
