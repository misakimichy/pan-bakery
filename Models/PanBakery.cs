using System;

namespace PanBakery.Models
{
    class Bread
    {
        public string BreadName { get; set; }
        public int BreadPrice { get; set; }
        public int BreadCount { get; set; }

        public Bread (string breadName)
        {
            BreadName = breadName;
            BreadPrice = 5;
            BreadCount = 0;
        }
    }

    class Pastry
    {
        public string PastryName { get; set; }
        public int PastryPrice { get; set; }
        public int PastryCount { get; set; }
        public Pastry (string pastryName)
        {
            PastryName = pastryName;
            PastryPrice = 2;
            PastryCount = 0;
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
        public void CountBread(int BreadAmount)
        {
            // Loop through and add to the bread list
            for(int i = 0; i < BreadAmount; i++)
            {
                Bread bread = new Bread();
                Breads.Add(bread);
            }
        }

        public void CountPastry(int PastryAmount)
        {
            // Loop through and add to the pastry list
            for(int i = 0; i < PastryAmount; i++)
            {
                Pastry pastry = new Pastry();
                Pastries.Add(pastry);
            }
        }
    }
}