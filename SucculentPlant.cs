using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvOOPLabb6
{
    public class SucculentPlant
    {

        //properties (class members)
        public string Looks { get; set; }
        public string PlantNickname { get; set; }
        public string MostInWhatContinent { get; set; }
        public string StorageOfWater { get; set; }


        //constructor with imparameters
        public SucculentPlant(string looks, string plantNickname,
        string mostInWhatContinent, string storageOfWater)
        {
            Looks = looks;
            PlantNickname = plantNickname;
            MostInWhatContinent = mostInWhatContinent;
            StorageOfWater = storageOfWater;

        }

        public void PrintSucculent()
        {

            Console.WriteLine("  __   __");
            Console.WriteLine("/  \\./  \\/\\_");
            Console.WriteLine("__{^\\_ _}_   )  }");
            Console.WriteLine("/  /\\_/^\\._}_/  /");
            Console.WriteLine("(  (__{(())}\\__}./");
            Console.WriteLine("\\__/{/(_)\\_}  )\\");
            Console.WriteLine("(   (__)_)_/  )");
            Console.WriteLine("\\__/     \\__/\\");
            Console.WriteLine("  \\__,--'");

        }
    }
}