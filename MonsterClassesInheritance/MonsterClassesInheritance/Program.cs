using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static void DisplayMenu()
        {
            bool exitMenu = false;
            SeaMonster suzy = InitializeSeaMonster();
            SpaceMonster john = InitializeSpaceMonster();

            DisplayHeader("Menu");

            do
            {
                Console.WriteLine("1)Display Monster");
                Console.WriteLine("2)Exit");
                Console.WriteLine("Enter Choice");
                int userChoice = 0;

                while (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("Please Enter a valid choice!");
                    
                };

                switch (userChoice)
                {
                    case 1:
                        DisplayMonsterInfoScreen(suzy, john);
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }

            } while (!exitMenu);
        }

        static void DisplayWelcomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("\tWelcome to The Monster Class Program. ");
            DisplayContinuePrompt();
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster)
        {
            DisplayHeader("Monster Information");

            DisplaySeaMonster(seaMonster);
            Console.WriteLine();
            DisplaySpaceMonster(spaceMonster);

            DisplayContinuePrompt();
        }

        private static void DisplaySeaMonster(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.ID}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Active: {(seaMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Has Gills: {(seaMonster.HasGills ? "Yes" : "No")}");
            Console.WriteLine($"Is the Monster Happy: {(seaMonster.IsHappy())}");
            Console.WriteLine($"Nickname: {seaMonster.Nickname}");
            Console.WriteLine($"Casualty: {seaMonster.Casualties}");
            Console.WriteLine($"People Friendly:{(seaMonster.LikesHumans ? "Yes" : "No")}");
           


            seaMonster.Greeting();
            Console.WriteLine($"You attack {seaMonster.Name} and they {seaMonster.MonsterBattleResponses()}");
        }

        private static void DisplaySpaceMonster(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.ID}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Active: {(spaceMonster.IsActive ? "Yes" : "No")}");

            spaceMonster.Greeting();
            Console.WriteLine($"You attack {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponses()}");
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                ID = 357,
                Name = "Suzy",
                IsActive = true,
                Age = 425,
                HasGills = false,
                SeaName = "Caspian",
                Nickname = "Lazy Susan",
                Casualties = 1234678,
                LikesHumans = false
                
            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                ID = 357,
                Name ="John",
                Age= 355,
                HasSpaceShip= true,
                IsActive= false,
                Nickname = "Lazy Susan",
                Casualties = 2768973,
                LikesHumans = false
            };
        }
        static void DisplayContinuePrompt()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headerText);
            Console.WriteLine();
        }
        static void DisplayClosingScreen()
        {
            DisplayHeader("ClosingScreen");
            Console.WriteLine("Thank you for using my app. Press any key to exit");
            Console.ReadKey();
        }
    }
}  
