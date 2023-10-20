using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class Animal
    {   

        //properties (class members)
        public string ColorPattern { get; set; }
        public string Gender { get; set; }
        public string Nickname { get; set; }
        public int PopulationWorldWide { get; set; }
        public string MostInWhatCountry { get; set; }


        //constructor with imparameters
        public Animal(string colorPattern, string gender, string nickname, 
        int populationWorldWide, string mostInWhatCountry)
        {
            ColorPattern = colorPattern;
            Gender = gender;
            Nickname = nickname;
            PopulationWorldWide = populationWorldWide;
            MostInWhatCountry = mostInWhatCountry;

        }

        //methodds that printing out in console

        public virtual void MakeSound()
        {
            Console.WriteLine("animals can make a sound");
        }
        public virtual void Runs()
        {
            Console.WriteLine("Animals can run");
        }
        public virtual void Eat()
        {
            Console.WriteLine("animals do eat");
        }

        public virtual void SplitCodeforANicerLook()
        {
            Console.WriteLine("______________________________");
        }
    }
}
