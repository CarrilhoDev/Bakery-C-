using System.Collections.Generic;

namespace CakeClasses
{
    public class CustomCake : Cake
    {
        public double DesignCost { get; set; }
        public string Occasion { get; set; }
        public double Size { get; set; }
        public string Design { get; set; }

        
        public CustomCake() { }

        public CustomCake(string flavour, double numOfLayers, string occasion, double size, string design)
            : base(flavour, numOfLayers)
        {
            Occasion = occasion;
            Size = size;
            Design = design;
            Price = 20.0;
        }
                  

        public override double CakeCost()
        {
            if (Design == "Polka Dots")
            {
                DesignCost = 5.0;
            }
            else if (Design == "Edible Images")
            {
                DesignCost = 12.0;
            }
            else if (Design == "Fondant Bow")
            {
                DesignCost = 10.0;
            }
            else if (Design == "3D Figures")
            {
                DesignCost = 15.0;
            }
            return base.CakeCost() + Size + DesignCost;
        }

        public override string ToString()
        {
            return "1 " + base.ToString() + " with " + Design + " design for " + Occasion + " occasion and that size is " + Size
                + " inches, ";
        }



    }
}
