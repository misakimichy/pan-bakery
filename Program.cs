using System;
using System.Collections.Generic;
using PanBakery.Models;

namespace PanBakery
{
    class Program
    {
        public static void Main()
        {
            int totalAmount = 0;

            TotalOrder newOrder = new TotalOrder();

            InitMessage();

            int breadAmount = TakeBreadOrder();
            newOrder.AddBread(breadAmount);

            int pastryAmount = TakePastryOrder();
            newOrder.AddPastry(pastryAmount);

            totalAmount = newOrder.CalculateTotal();
            showReceipt(breadAmount, pastryAmount, totalAmount);
        }

        public static void InitMessage()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pan Bakery!   ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\nPan Bakery sells breads and pastries.");
            Console.WriteLine("Each bread is $5. Buy 2, get 1 free!");
            Console.WriteLine("Each pastry is $2. Buy 1 for $2 or 3 for $5!");
            Console.WriteLine("-----------------------------------");
        }
        public static void EnterValid()
        {
            Console.WriteLine("Please type 'Y' for Yes, 'N' for No.");
        }
        public static int TakeBreadOrder()
        {
            Console.WriteLine("\nWould you like to buy some breads?(Y/N)");

            string userInput = Console.ReadLine().ToUpper();

            if (userInput != "Y")
            {
                return 0;
            }

            Console.WriteLine("\nHow many loaves of bread would you like to purchase?");

            // Return breadAmount if valid integer.
            int breadAmount = 0;
            bool breadInput = Int32.TryParse(Console.ReadLine(), out breadAmount);
            if (breadInput)
            {
                return breadAmount;
            }

            // Did not enter a valid integer, start over.
            Console.WriteLine("\nPlease enter number to purchase.");
            return TakeBreadOrder();
        }
        public static void AskPastry()
        {
            Console.WriteLine("Would you like to buy some pastries?(Y/N)");
        }
        public static int TakePastryOrder()
        {
            Console.WriteLine("\nWould you like to buy some pastries?(Y/N)");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput != "Y")
            {
                return 0;
            }

            Console.WriteLine("\nHow many pastries would you like to purchase?");

            // Return pastryAmount if valid integer.
            int pastryAmount = 0;
            bool breadInput = Int32.TryParse(Console.ReadLine(), out pastryAmount);
            if (breadInput)
            {
                return pastryAmount;
            }

            // Did not enter a valid integer, start over.
            Console.WriteLine("\nPlease enter number to purchase.");
            return TakePastryOrder();
        }
        public static void showReceipt(int breadAmount, int pastryAmount, int totalAmount)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"{breadAmount} loaves of breads.");
            Console.WriteLine($"{pastryAmount} of pastries");

            Console.WriteLine($"Your total is ${totalAmount}");
            Console.WriteLine("\nSee you next time!");
            Console.WriteLine("------------------------");
        }
    }
}