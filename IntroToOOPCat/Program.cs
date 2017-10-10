using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat mittens = new Cat();

            //mittens.Name = "Mittens";

            //Cat secondCat = new Cat("Oz", 3, "orange and white");

            //Console.WriteLine(mittens.Name);
            //Console.WriteLine(secondCat.Name);

            //mittens.Eat(); //<--in this one, mittens IS hungry, so it eats, and now he's not hungry.
            //mittens.Eat(); //<-- in this one, mittens ISN'T even hungry so it doesn't do anything.
            //mittens.WorkOut(); 


            //Dog firstDoge = new Dog();

            //firstDoge.Weight = 60.00;
            //firstDoge.Height = 3.2f;
            //firstDoge.FurLength = "flowing mane";
            //firstDoge.RunningSpeed = "will fetch....eventually..";

            //firstDoge.Groom();
            //Console.WriteLine(firstDoge.FurLength);

            //firstDoge.Run();
            //Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            //Console.WriteLine(firstDoge.RunningSpeed);

            //firstDoge.Bark();




            //Dog secondDoge = new Dog("fluffy", 4.04f);

            //Console.WriteLine(secondDoge.FurLength);

            //secondDoge.Groom();

            //Console.WriteLine(secondDoge.FurLength);

            //secondDoge.RunningSpeed = "Faster than lightning.";

            //Console.WriteLine(secondDoge.RunningSpeed);

            //secondDoge.Run();

            //Console.WriteLine(secondDoge.RunningSpeed);

            //secondDoge.Weight = 78.9;

            //Console.WriteLine(secondDoge.Weight);

            //secondDoge.Potty();

            //Console.WriteLine(secondDoge.Weight);

            //secondDoge.Bark();



            ////Time to destroy the world.
            Villian Hobbes = new Villian("Chaotic Good", "tummy trouble");

            Console.WriteLine("Hello, world.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("I have been called the Greatest Man's Best Friend of all time...");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("...but it really depends on who and when you ask.");
            Hobbes.EvilLaugh();
            Console.WriteLine("Bwahahahaha!");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Ahem. For example, there was a perfect burrito, all lonely and hot just\n lying there - so I ate it.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Right as I swallowed, my human saw me and yelled, 'NO!' \nHeat spread through my belly, and suddenly I couldn't keep still!");

            Hobbes.EatsBurrito();

            Hobbes.Healthpoints = 5;

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(Hobbes.Abilities);
            Console.WriteLine("I ran.\nHuman: 'Bad dog!'");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Suddenly, I found myself backed into a corner, and the hair \nalong my spine bristled.");
            Hobbes.Attack();
            Console.WriteLine("I bared my teeth to growl, when...I tossed my burrito.");

            //HP drain -- hard way
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(Hobbes.Abilities);
            Console.WriteLine(Hobbes.Healthpoints);
            Hobbes.EnergyLevel();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Hobbes.Healthpoints);
            Hobbes.EnergyLevel();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Hobbes.Healthpoints);
            Hobbes.EnergyLevel();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Hobbes.Healthpoints);
            Hobbes.EnergyLevel();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Hobbes.Healthpoints);
            Hobbes.EnergyLevel();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Hobbes.Healthpoints);

            Console.WriteLine("Human: 'Aww. Poor baby. C'mere.'");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("My human picked me up and held me close.");

            //HP boost -- easy way!
            Hobbes.Cuddle();

            Console.WriteLine("And I felt better.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("And as I nestled in, I heard my human whisper:");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("'Who's the Greatest Man's Best Friend?'");
            Hobbes.EvilLaugh();




        }
    }
}
