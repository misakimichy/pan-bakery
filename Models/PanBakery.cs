using System;

namespace PanBakery.Models
{
    class Bread
    {
        public string BreadName { get; set; }
        public int BreadPrice { get; set; }

        public Bread (string breadName, int breadPrice)
        {
            BreadName = breadName;
            BreadPrice = breadPrice;
        }
    }

    class Pastry
    {
        public string PastryName { get; set; }
        public int PastryPrice { get; set; }
        public Pastry (string pastryName, int pastryPrice)
        {
            PastryName = pastryName;
            PastryPrice = pastryPrice;
        }
    }
}