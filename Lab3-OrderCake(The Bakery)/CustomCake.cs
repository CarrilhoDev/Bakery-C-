using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class CustomCake : Cake
    {
        public string Occasion { get; set; }
        public int Size { get; set; }
        public string Design { get; set; }
        private double DesignCost { get; set; }

        //size price is same as the size unit. For insatnce, 6 inch sized cake adds 6 towards cake cost.
        public CustomCake(string flavour, int numLayers,string occasion, int diameter, string design)
            :base(flavour,numLayers)
        {
            Occasion = occasion;
            Size = diameter;
            Design = design;
             switch (Design)
             {
                 case "Polka Dots":
                    DesignCost = 5;
                     break;
                 case "Edible Images":
                     DesignCost = 12;
                     break;
                 case "Fondant Bow":
                    DesignCost = 10;
                     break;
                 default:
                    DesignCost = 15;
                     break;
             }
        }
        public override double CalculateCakeCost()
        {
            return base.CalculateCakeCost() + Size + DesignCost;
        }
        public override string ToString()
        {
            return base.ToString() +  " with " + Design + " design for " + Occasion + " occassion and size is " + Size + " inches " ;
        }
    }
}
