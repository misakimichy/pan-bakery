using System;
using System.Collections.Generic;
using PanBakery.Models;

namespace PanBakery
{
    class Program
    {
        public static Bread bread1 = new Bread("White bread", 3);
        public static Bread bread2 = new Bread("Sourdough", 4);
        public static Bread bread3 = new Bread("Baguette", 5);
        public static Bread bread4 = new Bread("Focaccia", 6);
        public static List<Bread> Breads = new List<Bread>() { bread1, bread2, bread3, bread4 };

        public static Pastry pastry1 = new Pastry("Croissant", 3);
        public static Pastry pastry2 = new Pastry("Pain au chocolat", 4);
        public static Pastry pastry3 = new Pastry("Cinnamon Roll", 5);
        public static Pastry pastry4 = new Pastry("Pirozhki", 6);
        public static List<Pastry> Pastries = new List<Pastry>() { pastry1, pastry2, pastry3, pastry4 };
        public static string userInput = "";
        public static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pan Bakery!  ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nHere is the lists of our breads and pastries.");

            Console.WriteLine("\nPan Bakery's Breads");
            foreach(Bread bread in Breads)
            {
                Console.WriteLine($"- {bread.BreadName}: ${bread.BreadPrice}");
            }

            Console.WriteLine("\nPan Bakery's Pastries");
            foreach(Pastry pastry in Pastries)
            {
                Console.WriteLine($"- {pastry.PastryName}: ${pastry.PastryPrice}");
            }

            AskBread();
            if (userInput == "Y")
            {
                PurchaseBread();
                if (userInput == "Y")
                {
                    PurchaseBread();
                }
                else if (userInput == "N")
                {
                    goto purchasePastry;
                }
                // When use types besides 'Y' or 'N'
                else
                {
                    EnterValid();
                    PurchaseBread();
                }
            }
            else if (userInput == "N")
            {
                AskPastry();
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
                }
            }
            // When use types besides 'Y' or 'N'
            else
            {
                EnterValid();
                AskBread();
            }
            purchasePastry: PurchasePastry();
        }
        public static void EnterValid(){
            Console.WriteLine("Please type 'Y' for Yes, 'N' for No.");
        }
        public static void AskBread()
        {
            Console.WriteLine("\nWould you like to buy some breads?(Y/N)");
            userInput = Console.ReadLine().ToUpper();
        }
        public static void AskPastry()
        {
            Console.WriteLine("Would you like to buy some pastries?(Y/N)");
            userInput = Console.ReadLine().ToUpper();
        }
        public static void PurchaseBread()
        {
            Console.WriteLine("\nPlease enter a number that you'd like to purchase.");
            for(int i = 0; i < Breads.Count; i++)
            {
                Console.WriteLine($"{i}: {Breads[i].BreadName} ${Breads[i].BreadPrice}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to buy more bread? (Y/N)");
            userInput = Console.ReadLine().ToUpper();
        }
        public static void PurchasePastry()
        {
            Console.WriteLine("\nPlease enter a number that you'd like to purchase.");
            for(int i = 0; i < Pastries.Count; i++)
            {
                Console.WriteLine($"{i}: {Pastries[i].PastryName} ${Pastries[i].PastryPrice}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to buy more pastries? (Y/N)");
            userInput = Console.ReadLine().ToUpper();
        }

    }
}