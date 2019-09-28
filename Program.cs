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
            int breadCount = 0;
            int pastryCount = 0;
            int totalAmount = 0;
            TotalOrder newOrder = new TotalOrder();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pan Bakery!   ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\nPan Bakery sells breads and pastries.");
            Console.WriteLine("Each bread is $5. Buy 2, get 1 free!");
            Console.WriteLine("Each pastry is $2. Buy 1 for $2 or 3 for $5!");
            Console.WriteLine("-----------------------------------");

            AskBread();
            userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
                breadCount = int.Parse(Console.ReadLine());
                newOrder.CountBread(breadCount);
            }
            else if (userInput == "N")
            {
                AskPastry();
                userInput = Console.ReadLine().ToUpper();
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
            userInput = Console.ReadLine();
            pastryCount = int.Parse(Console.ReadLine());
            newOrder.CountPastry(pastryCount);
            totalAmount = newOrder.CalculateTotal();
            Console.WriteLine("------------------------");
            Console.WriteLine($"{breadCount} loaves of breads.");
            Console.WriteLine($"{pastryCount} of pastries");
            Console.WriteLine($"Your total is ${totalAmount}");
            Console.WriteLine("\nSee you next time!");
            Console.WriteLine("------------------------");
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
            Console.WriteLine("\nHow many pastries would you like to purchase?");
        }
    }
}