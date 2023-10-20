using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Zebra : Animal 
    {
        public string ExellentVision  { get; set; }

        public Zebra(string colorPattern, string gender, string nickname,
        int populationWorldWide, string mostInWhatCountry, string exellentVision)
        : base(colorPattern, gender, nickname, populationWorldWide, mostInWhatCountry)
        {
            ExellentVision = exellentVision;
        }

        public void Kick()
        {
            Console.WriteLine("zebra can kick predators to flee");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The zebra makes a barking sound almost like a dog");
        }
        public override void Runs()
        {
            Console.WriteLine("The zebra is running right now, its fast!");
        }
        public override void Eat()
        {
            Console.WriteLine("Zebras like to eat grass ");
        }

        public void PrintZebra()
        {
            Console.WriteLine("_,,");
            Console.WriteLine("\"-.\\=    barky Sound!");
            Console.WriteLine(" \\=   _.~");
            Console.WriteLine("_|/||||)_");
            Console.WriteLine("\\        \\");



        }

    }
}
