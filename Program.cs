using System;
using System.Collections.Generic;
using PanBakery.Models;

namespace PanBakery
{
    class Program
    {
        public static void Main()
        {
            Bread bread1 = new Bread("White bread", 3);
            Bread bread2 = new Bread("Sourdough", 4);
            Bread bread3 = new Bread("Baguette", 5);
            Bread bread4 = new Bread("Focaccia", 6);
            
            List<Bread> Breads = new List<Bread>() { bread1, bread2, bread3, bread4 };

            Pastry pastry1 = new Pastry("Croissant", 3);
            Pastry pastry2 = new Pastry("Pain au chocolat", 4);
            Pastry pastry3 = new Pastry("Cinnamon Roll", 5);
            Pastry pastry4 = new Pastry("Pirozhki", 6);
            List<Pastry> Pastries = new List<Pastry>() { pastry1, pastry2, pastry3, pastry4 };
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pan Bakery!  ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nHere is the lists of breads and pastries that we have.");

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
        }
    }
}