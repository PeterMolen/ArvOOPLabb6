using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Gorilla : Animal
    {
        public string Muscles { get; set; }

        public Gorilla(string colorPattern, string gender, string nickname,
        int populationWorldWide, string mostInWhatCountry, string muscles)
        :base(colorPattern, gender, nickname, populationWorldWide, mostInWhatCountry)
        {
            Muscles = muscles;
        }

        public void BeatingChest()
        {
            Console.WriteLine("the Gorilla Pounding his chest, Tarzan style!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The Gorilla makes a hooting sound");
        }
        public override void Runs()
        {
            Console.WriteLine("Gorillas are fast, but dont want to run right now");
        }
        public override void Eat()
        {
            Console.WriteLine("the Gorilla Eats a banana");
        }

        public void printGorilla()
        {
            Console.WriteLine("     .\"`\".");
            Console.WriteLine(" .-./ _ = _\\.-.");
            Console.WriteLine("{ (, (oYo),)   }");
            Console.WriteLine("{{ |   \"   |} }    HOOT HOOT!");
            Console.WriteLine("{ { \\(---)/  }");
            Console.WriteLine("{{  }'-=-'{ } }");
            Console.WriteLine("{ { }._:_.{  }}");
            Console.WriteLine("((((\\)    (/))))");


        }

    }
}
