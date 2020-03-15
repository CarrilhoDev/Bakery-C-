using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Cake
    {
        public int NumOfLayers { get; set; }
        public string Flavour { get; set; }
        public double Price { get; set; }
        //change cake price to 20 for lab 5
        public const double CAKE_PRICE = 20;
        //no cost for flavour but number of layers have price
        public const int LAYER_PRICE = 3;

        public Cake()
        {
            Flavour = "";
            NumOfLayers = 0;
        }

        public Cake(string flavour, int numLayers)
        {
            NumOfLayers = numLayers;
            Flavour = flavour;
        }

        public virtual double CalculateCakeCost()
        {
            return CAKE_PRICE + (LAYER_PRICE * NumOfLayers);
        }

        public override string ToString()
        {
            return " " + Flavour + " flavoured cake with " + NumOfLayers + " layer(s)";
        }
    }
}
