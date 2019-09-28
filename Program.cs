using System;
using System.Collections.Generic;
using PanBakery.Models;

namespace PanBakery
{
    class Program
    {
        public static void Main()
        {
            string userInput;
            int breadCount;
            int pastryCount;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pan Bakery!   ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nHere is the list of our breads and pastries.");
            Console.WriteLine("Each bread is $5. Buy 2, get 1 free!");
            Console.WriteLine("Each pastry is $2. Buy 1 for $2 or 3 for $5!");
            Console.WriteLine("-----------------------------------");

            AskBread();
            userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
                breadCount = int.Parse(Console.ReadLine());
            }
            else if (userInput == "N")
            {
                AskPastry();
                pastryCount = int.Parse(Console.ReadLine());
                if (userInput == "Y")
                {
                    goto purchasePastry;
                }
                else if (userInput == "N")
                {
                    Console.WriteLine("Thank you for visiting us. See you next time!");
                    return;
                }
                // When use types besides 'Y' or 'N'
                else
                {
                    EnterValid();
                    AskPastry();
                    userInput = Console.ReadLine().ToUpper();
                }
            }
            // When use types besides 'Y' or 'N'
            else
            {
                EnterValid();
                AskBread();
                userInput = Console.ReadLine().ToUpper();
            }
            purchasePastry: PurchasePastry();
            pastryCount = int.Parse(Console.ReadLine());
        }
        public static void EnterValid(){
            Console.WriteLine("Please type 'Y' for Yes, 'N' for No.");
        }
        public static void AskBread()
        {
            Console.WriteLine("\nWould you like to buy some breads?(Y/N)");
        }
        public static void AskPastry()
        {
            Console.WriteLine("Would you like to buy some pastries?(Y/N)");
        }
        public static void PurchasePastry()
        {
            Console.WriteLine("\nHow many pastries would you like to purchase.");
        }
    }
}