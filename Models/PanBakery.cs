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

        public int CalculatePrice()
        {
            int breadTotal = 0;
            int pastryTotal = 0;
            
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
}