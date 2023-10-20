using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Humen : Animal
    {
        public string Intelligence { get; set; }

        public Humen(string colorPattern, string gender, string nickname,
        int populationWorldWide, string mostInWhatCountry, string intelligence)
        : base(colorPattern, gender, nickname, populationWorldWide, mostInWhatCountry)
        {
            Intelligence = intelligence;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Humen talk to each other, these humen talks english to each other\nHello!");
        }
        public override void Runs()
        {
            Console.WriteLine("Humen can run");
        }
        public override void Eat()
        {
            Console.WriteLine("Humens must eat");
        }

        public void printHumen()
        {
            Console.WriteLine("      ///\"\\\\");
            Console.WriteLine("       |6 6|");
            Console.WriteLine(".@@@. __) (__");
            Console.WriteLine("@6 6@/  \\./  \\");
            Console.WriteLine("@ = @ :  :  : \\");
            Console.WriteLine("_) (_'|  :  |) )");
            Console.WriteLine("/' \\./ '\\  : |_/");
            Console.WriteLine("/ /\\ _ /\\ \\ |)");


        }
    }
}
