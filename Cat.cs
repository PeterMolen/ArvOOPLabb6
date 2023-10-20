using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Cat : Animal // inheritance 
    {
        //protperty
        public string Elasticity { get; set; }

        //constructor
        public Cat(string colorPattern, string gender, string nickname,
        int populationWorldWide, string mostInWhatCountry, string elasticity)
        : base(colorPattern, gender, nickname, populationWorldWide, mostInWhatCountry) //base inheritance.
        {
            Elasticity = elasticity;
        }

        public void CatJump()
        {
            Console.WriteLine("it can jump high into the air before it lands");
        }

        public override void MakeSound()
        {
            Console.WriteLine(" The Cat says: Mjau!");
        }
        public override void Runs()
        {
            Console.WriteLine("The cat dont want to run right now, it's lazy");
        }
        public override void Eat()
        {
            Console.WriteLine("Cats like catfood, thats obvious");
        }

        public void PrintCat()
        {
            Console.WriteLine(" /\\_/\\           ___");
            Console.WriteLine("= o_o =_______    \\ \\    MJAU!");
            Console.WriteLine(" __^      __(  \\.__) )");
            Console.WriteLine("(@)<_____>__(_____)____/");

        }
    }
}
