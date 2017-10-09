using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPCat
{
    class Villian
    {
        //STATES
        //fields

        private string alignment;
        private int numberOfNemeses;
        private string abilities;
        private int HP;
        private string name;

        //Properties

        public string Alignment
        {
            get { return this.alignment; }
            set { this.alignment = value; }
        }
        public int NumberOfNemeses
        {
            get { return this.numberOfNemeses; }
            set { this.numberOfNemeses = value; }
        }
        public string Abilities
        {
            get { return this.abilities; }
            set { this.abilities = value; }
        }
        public int Healthpoints
        {
            get { return this.HP; }
            set { this.HP = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        //Constructors
        public Villian()
        {

        }

        public Villian(string alignment, string abilities)
        {
            this.alignment = alignment;
            this.abilities = abilities;
        }
        public Villian(int numberOfNemeses, int HP)
        {
            this.numberOfNemeses = numberOfNemeses;
            this.HP = HP;
        }
        public Villian(string name)
        {
            this.name = name;
        }

        //Methods
        public void EvilLaugh()
        {
            Console.WriteLine("\a\a\a\a\a");
        }
        public void Attack()
        {
            abilities = "*tummy rumble* ...that burrito wasn't a good idea.";
        }
        public void EatsBurrito()
        {
            abilities = "You cannot catch me now!";
        }
        public void EnergyLevel()
        {

            HP -= 1;
        }

        public void Cuddle()
        {
            Console.WriteLine(Healthpoints);
            System.Threading.Thread.Sleep(1000);
            do 
            {
                HP++;
                Console.WriteLine(Healthpoints);
                System.Threading.Thread.Sleep(1000);
            }
            while (Healthpoints < 5);
        }

    }
}
