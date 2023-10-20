using System.Runtime.InteropServices;

namespace ArvOOPLabb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objects, instans of main class Animal, underclasses; Gorilla,Zebra,Cat
            // Lion & Leopard under clases to cat. added a humen class, and plants.
            //and the imparameters from the constructors, here you set it up.or (chooce the value)

            Gorilla gorilla = new Gorilla("Black", "Male", "Silverback", 316000, "Congo", "Big Flex");
            Zebra zebra = new Zebra("Stripes", "Female", "Stripy", 800000, "Kenya", "Exellent vision");
            Cat cat = new Cat("Brown", "Female", "Missy", 600000000, "Kenya", "Very flexible");
            Lion lion = new Lion("Orange", "Male", "KisseKatt", 20000, "South of sahara desert", 
            "Very flexible", "Likes to hunt");
            Leopard leopard = new Leopard("Rosettes", "Female", " run Forest run", 250000, "India", 
            "Very flexible", "the fastest");
            Humen humen = new Humen("skin color", "Male", "Homo Sapiens", 8, "india", "Intelligent");
            SucculentPlant succulent = new SucculentPlant("thick & fleshy", "JuicyPlant", "Africa",
                "can store water in stems and leaves");
            Cactus cactus = new Cactus("green and spiney", "Cactus", "SouthAmerica", 
                "Storage of water", "lots of spines");
            AloeVera aloevera = new AloeVera("thick fleshy green, with white-teeths on leaves",
                "Aloe", "Australia", "storage of water", "Reducing the healing time of burns by around 9 days");


            //with help of the costructor, we can make new animal objekt like this below:
            //Animal animalname = new Animal("Color pattern", "Gender", "Nickname", 10, "mostInWhatCountry");
           

            //calling different methods + Writing out both from methods and from constructors imparameters 
            Console.WriteLine(gorilla.Nickname + 
            "\norigin: " + gorilla.MostInWhatCountry);
            gorilla.BeatingChest();
            gorilla.MakeSound();
            gorilla.printGorilla();
            gorilla.SplitCodeforANicerLook();
                
            Console.WriteLine(zebra.Nickname +
            "\nthere is :" + zebra.PopulationWorldWide + " in the world");
            zebra.MakeSound();
            zebra.Runs();
            zebra.PrintZebra();
            zebra.Eat();
            zebra.Kick();
            zebra.SplitCodeforANicerLook();
          
            Console.WriteLine(cat.Nickname + " : " + cat.Gender);
            cat.MakeSound();
            cat.PrintCat();
            cat.Runs();
            cat.Eat();
            cat.SplitCodeforANicerLook();

            Console.WriteLine(lion.Nickname + " : " + lion.Hunting);
            lion.MakeSound();
            lion.PrintLion();
            lion.CatJump(); // only the cat, the lion and the loepard can do a cat jump.
            lion.SplitCodeforANicerLook();

            Console.WriteLine(leopard.Nickname + " : " + leopard.Fast);
            leopard.MakeSound();
            leopard.PrintLeopard();
            leopard.Runs();
            leopard.RunsExtraFast();
            leopard.SplitCodeforANicerLook();

            Console.WriteLine(humen.Nickname + " can have different " + humen.ColorPattern + " there are " +
                humen.PopulationWorldWide + "Billions" + " in the World");
            humen.MakeSound();
            humen.printHumen();
            humen.SplitCodeforANicerLook();

            Console.WriteLine(succulent.PlantNickname + " " + succulent.Looks + " " + succulent.StorageOfWater);
            succulent.PrintSucculent();
            humen.SplitCodeforANicerLook();

            Console.WriteLine(cactus.PlantNickname + "" + cactus.Looks + " most in: " + cactus.MostInWhatContinent);
            cactus.PrintCactus();
            humen.SplitCodeforANicerLook();

            Console.WriteLine(aloevera.PlantNickname + " " + aloevera.HealingEffect);
            aloevera.PrintAloe();
            humen.SplitCodeforANicerLook();

            Console.ReadKey();

        }
    }

}

