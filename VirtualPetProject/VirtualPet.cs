using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class VirtualPet

    {
        //VARIABLE declarations
        private string name;
        private string bodyColor;
        private string beakColor;
      
        //CLASS CONSTRUCTOR declaration
        //is used to set the initial state
        public VirtualPet()
        {
            this.name = "GUI the Goose";
            this.bodyColor = "Grey";
            this.beakColor = "Orange";
        }

        //PROPERTIES (get and set)
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string BodyColor
        {
            set { this.bodyColor = value; }
            get { return this.bodyColor; }
        }

        public string BeakColor
        {
            set { this.beakColor = value; }
            get { return this.beakColor; }
        }

        //METHODS
        public void changePetName()
        {
            Console.WriteLine("Enter a new name: ");
            Name = Console.ReadLine() + " GUI the Goose";
            Console.WriteLine("Hello I'm " + Name + " and I'm ready to play!\n");
        }
        public void changeBodyColor()
        {
            Console.WriteLine("Enter a new body color: ");
            BodyColor = Console.ReadLine();
            Console.WriteLine(BodyColor + " is my favorite color!\n");
        }

        public void changeBeakColor()
        {
            Console.WriteLine("Enter a new beak color: ");
            BeakColor = Console.ReadLine();
            Console.WriteLine(BeakColor + " Wow look at you!\n ");
        }
    }
}