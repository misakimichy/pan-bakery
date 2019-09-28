using System;
using System.Collections.Generic;

namespace PanBakery.Models
{
    class Bread
    {
        public string BreadName { get; set; }
        public int BreadPrice { get; set; }
        public Bread ()
        {
            BreadName = "Baguette";
            BreadPrice = 5;
        }
    }

    class Pastry
    {
        public string PastryName { get; set; }
        public int PastryPrice { get; set; }
        public Pastry ()
        {
            PastryName = "Croissant";
            PastryPrice = 2;
        }
    }

    // Backend logic for both Bread and Pastry.
    class TotalOrder
    {
        public List<Bread> Breads { get; set; }
        public List<Pastry> Pastries { get; set; }
        public TotalOrder()
        {
            Breads = new List<Bread>();
            Pastries = new List<Pastry>();
        }
        // Takes user's bread purchase amount as parameter
        public void CountBread(int breadAmount)
        {
            // Loop through and add to the bread list
            for(int i = 0; i < breadAmount; i++)
            {
                Bread bread = new Bread();
                Breads.Add(bread);
            }
        }

        // Takes user's pastry purchase amount as parameter
        public void CountPastry(int pastryAmount)
        {
            // Loop through and add to the pastry list
            for(int i = 0; i < pastryAmount; i++)
            {
                Pastry pastry = new Pastry();
                Pastries.Add(pastry);
            }
        }

        // Function to return total price of bread and pastry.
        public int CalculateTotal()
        {
            int breadTotalPrice = 0;
            int pastryTotalPrice = 0;
            // Bread -  Buy 2, get 1 free.
            // Increment BreadPrice only when it's first and second bread.
            for (int i = 0; i < Breads.Count; i++)
            {
                if((i + 1) % 3 != 0)
                {
                    breadTotalPrice += Breads[i].BreadPrice;
                }
            }
            // Pastry - Buy 1 for $2 or 3 for $5.
            // Third pastry price is going to half.
            for (int j = 0; j < Pastries.Count; j++)
            {
                if((j + 1) % 3 != 0)
                {
                    pastryTotalPrice += Pastries[j].PastryPrice;
                }
                else
                {
                    pastryTotalPrice += Pastries[j].PastryPrice / 2;
                }
            }
            int totalAmount = breadTotalPrice + pastryTotalPrice;
            return  totalAmount;
        }
    }
}