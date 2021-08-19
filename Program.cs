using System;

namespace Formative_Assessement_2_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------");

           //Display the number for the type of wood
            Console.WriteLine("Enter 1 for Pine");
            Console.WriteLine("Enter 2 for Oak");
            Console.WriteLine("Enter 3 for Mahogany");

            Console.WriteLine("---------------------------------------------------------");

             
            Console.WriteLine("Enter a number for specific wood");
            var userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");

            // if user input 1 then print Pine  and price
            if (userInput == 1)
            {
                Console.WriteLine("Pine Tables Costs $100");
            }

            // if the user enter 2 then print oak and price
            if (userInput == 2)
            {
                Console.WriteLine("oak tables cost $225");
            }

            // if the user enter 3 then print Mahogany and the price
            if (userInput == 3)
            {
                Console.WriteLine("Mahogany table cost $310");
            }

            // if the user enter option higher than 3 and below 1 then it prints invaild Option and $0
            if (userInput >= 4 || userInput <= 0)
            {
                Console.WriteLine(" Invaild option. Set price $0");
            }
        }
    }
}

