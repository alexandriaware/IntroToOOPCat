using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPCat
{
    class Cat
    {
        //STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties
        public string Name
        {
            get { return this.name; }
            //you need a new get/set for every variable age and furColor
            set { this.name = value; }
        }


        //BEHAVIORS 
        //Constructors
        public Cat()
        {
        //default constructor has to have empty parentheses
        //but it can have stuff in the curly braces like 
        //this.name = name;
        }

        public Cat(string name, int age, string furColor) //overloaded constructor
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }



        //Methods
        public void Eat()
        {
            if (isHungry == true)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
       
        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }

    }


}
