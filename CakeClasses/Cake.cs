

namespace CakeClasses
{
    public abstract class Cake
    {
        public string Flavour { get; set; }
        public double Price { get; set; }
        public double NumOfLayers { get; set; }
        public double PricePerLayer { get; set; } = 3.0;

        public Cake() { }

        public Cake(string flavour, double numOfLayers)
        {
            Flavour = flavour;
            NumOfLayers = numOfLayers;
        }

       public virtual double CakeCost()
        {
            return Price + (NumOfLayers * PricePerLayer);
        }

       public override string ToString()
        {
            return Flavour + " flavoured cake with " + NumOfLayers + " layer(s) ";
        }
      
    }
}
