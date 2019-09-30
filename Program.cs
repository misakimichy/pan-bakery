using System;
using PanBakery.Models;

namespace PanBakery
{
    class Program
    {
        public static void Main()
        {
            int totalAmount = 0;

            Order order = new Order();

            WelcomeMessage();

            int breadAmount = SolicitBreadOrder();
            order.AddBread(breadAmount);

            int pastryAmount = SolicitPastryOrder();
            order.AddPastry(pastryAmount);

            totalAmount = order.CalculateTotal();
            showReceipt(breadAmount, pastryAmount, totalAmount);
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pan Bakery!   ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\nPan Bakery sells breads and pastries.");
            Console.WriteLine("Each bread is $5. Buy 2, get 1 free!");
            Console.WriteLine("Each pastry is $2. Buy 1 for $2 or 3 for $5!");
            Console.WriteLine("-----------------------------------");
        }
        public static int SolicitBreadOrder()
        {
            Console.WriteLine("\nWould you like to buy some breads?(Y/N)");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "N")
            {
                return 0;
            }
            else if (userInput != "Y")
            {
                Console.WriteLine("\nPlease type 'Y' for Yes, 'N' for No.");
                return SolicitBreadOrder();
            }
            return TakeBreadOrder();
        }

        public static int TakeBreadOrder()
        {
            Console.WriteLine("\nHow many loaves of bread would you like to purchase?");

            // Return breadAmount if valid integer.
            int breadAmount = 0;
            bool breadInput = Int32.TryParse(Console.ReadLine(), out breadAmount);
            if (!breadInput)
            {
                Console.WriteLine("\nPlease enter number to purchase.");
                return TakeBreadOrder();
            }
            return breadAmount;
        }
        public static int SolicitPastryOrder()
        {
            Console.WriteLine("\nWould you like to buy some pastries?(Y/N)");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "N")
            {
                return 0;
            }
            else if (userInput != "Y")
            {
                Console.WriteLine("\nPlease type 'Y' for Yes, 'N' for No.");
                return SolicitPastryOrder();
            }
            return TakePastryOrder();
        }
        public static int TakePastryOrder()
        {
            Console.WriteLine("\nHow many pastries would you like to purchase?");

            // Return pastryAmount if valid integer.
            int pastryAmount = 0;
            bool breadInput = Int32.TryParse(Console.ReadLine(), out pastryAmount);
            if (!breadInput)
            {
                Console.WriteLine("\nPlease enter number to purchase.");
                return TakePastryOrder();
            }
            return pastryAmount;
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