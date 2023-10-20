using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Lion : Cat
    {
        public string Hunting { get; set; }

        public Lion(string colorPattern, string gender, string nickname,
        int populationWorldWide, string mostInWhatCountry, string elasticity, string hunting)
        :base(colorPattern, gender, nickname, populationWorldWide, mostInWhatCountry, elasticity)
        {
            Hunting = hunting;
        }

        public void WaggingTail()
        {
            Console.WriteLine("The lion wagging it's tail");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The lion ROOAAARS!");
        }
        public override void Runs()
        {
            Console.WriteLine("The lion is fast, you dont want to get chased by it");
        }
        public override void Eat()
        {
            Console.WriteLine("Lions eat whatever");
        }



        public void PrintLion()
        {
            Console.WriteLine("  /'';;:;;''\\");
            Console.WriteLine(" (:;/\\,-,/\\;;)");
            Console.WriteLine("(:;{  d b  }:;)    ROOAAAR!!!");
            Console.WriteLine(" (:;\\__Y__/;;)-----------,,_");
            Console.WriteLine(",..\\  ,..\\      ___/___)__`\\");
            Console.WriteLine("(,,,)~(,,,)`-._##____________)");




        }
    }

}
