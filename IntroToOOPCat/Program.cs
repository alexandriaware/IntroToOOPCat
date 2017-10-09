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
            Cat mittens = new Cat();

            mittens.Name = "Mittens";

            Cat secondCat = new Cat("Oz", 3, "orange and white");

            Console.WriteLine(mittens.Name);
            Console.WriteLine(secondCat.Name);

            mittens.Eat(); //<--in this one, mittens IS hungry, so it eats, and now he's not hungry.
            mittens.Eat(); //<-- in this one, mittens ISN'T even hungry so it doesn't do anything.
            mittens.WorkOut(); 

        }
    }
}
