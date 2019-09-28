using System;
using System.Collections.Generic;
using PanBakery.Models;

namespace PanBakery
{
    class Program
    {
        public static Bread bread1 = new Bread("White bread");
        public static Bread bread2 = new Bread("Sourdough");
        public static Bread bread3 = new Bread("Baguette");
        public static Bread bread4 = new Bread("Focaccia");
        public static List<Bread> Breads = new List<Bread>() { bread1, bread2, bread3, bread4 };

        public static Pastry pastry1 = new Pastry("Croissant");
        public static Pastry pastry2 = new Pastry("Pain au chocolat");
        public static Pastry pastry3 = new Pastry("Cinnamon Roll");
        public static Pastry pastry4 = new Pastry("Pirozhki");
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
                Console.WriteLine($"- {bread.BreadName}");
            }
            Console.WriteLine("Each loaf is $5. Buy 2, get 1 free.");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\nPan Bakery's Pastries");
            foreach(Pastry pastry in Pastries)
            {
                Console.WriteLine($"- {pastry.PastryName}");
            }
            Console.WriteLine("Buy 1 for $2 or 3 for $5!");
            Console.WriteLine("-----------------------------------");


            AskBread();
            if (userInput == "Y")
            {
                PurchaseBread();
                if (userInput == "Y")
                {
                    Console.Write("How many breads do you want to purchase?");
                    int countBread = int.Parse(Console.ReadLine());
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
                Console.WriteLine($"{i}: {Pastries[i].PastryName}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to buy more pastries? (Y/N)");
            userInput = Console.ReadLine().ToUpper();
        }

    }
}