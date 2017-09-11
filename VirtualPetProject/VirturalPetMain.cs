using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class VirturalPetMain
    {
        static void Main(string[] args)
        {
            //Welcome Screen
            Console.WriteLine("Welcome to my virtual pet 1.0");
            Console.WriteLine("Press Enter to interact with my pet goose.");
            Console.WriteLine();
            Console.ReadLine();

            //Instantiate VirtualPet
            VirtualPet virtualPet = new VirtualPet();//petName is an instance of VirtualPet object

            string strMenuChoice;
            int menuChoice;

            //diplay state
            do
            {
                Console.WriteLine("My Virtual Pet is a goose.");
                Console.WriteLine("His name is: " + virtualPet.Name);
                Console.WriteLine("His body color is: " + virtualPet.BodyColor);
                Console.WriteLine("His beak color is: " + virtualPet.BeakColor);
                Console.WriteLine("\n");

                //Menu layout
                Console.WriteLine("Please make a selection of 1, 2 or 3 below: ");
                Console.WriteLine();
                Console.WriteLine("1) Change name");
                Console.WriteLine("2) Change body color");
                Console.WriteLine("3) Change beak color");
                Console.WriteLine("4) Exit program");
                Console.WriteLine("\n");

                //Processed menu options
                strMenuChoice = Console.ReadLine();
                menuChoice = int.Parse(strMenuChoice);

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("You chose to change GUI's name");
                        virtualPet.changePetName();
                        break;
                    case 2:
                        Console.WriteLine("You chose a different body color.");
                        virtualPet.changeBodyColor();
                        break;
                    case 3:
                        Console.WriteLine("You chose to change your beak color.");
                        virtualPet.changeBeakColor();
                        break;
                    case 4:
                        Console.WriteLine("Good-bye sucka!");
                        break;

                    default:
                        Console.WriteLine("I'm sorry, I don't understand that!");
                        break;
                }
            }
            while (menuChoice != 4);
            System.Environment.Exit(0);
        }
    }
 }

