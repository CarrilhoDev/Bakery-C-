using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Cake Cake { get; set; }
        public int NumOfCakes { get; set; }

        public Order()
        {
            Customer = new Customer();
            Cake = new Cake();
            NumOfCakes = 0;
        }

        public Order(Customer customer, Cake cake, int numCakes)
        {
            Customer = customer;
            Cake = cake;
            NumOfCakes = numCakes;
        }

        //Lab 4
        public Order(string fName, string lName, string flavour, int numLayers, int numCakes)
        {
            Customer = new Customer(fName, lName);
            Cake = new Cake(flavour, numLayers);
            NumOfCakes = numCakes;
        }

        //Lab 5
        public Order(string fName, string lName, string flavour, int numLayers, string occasion, int diameter, string design)
        {
            Customer = new Customer(fName, lName);
            Cake = new CustomCake(flavour, numLayers, occasion,diameter,design);
            NumOfCakes = 1;
        }

        //Lab 5
        public Order(string fName, string lName, string flavour, int numLayers)
        {
            Customer = new Customer(fName, lName);
            Cake = new Cake(flavour, numLayers);
            NumOfCakes = 1;
        }

        //modified for Lab 5
        public double CalculateCostWithTax()
        {
            return NumOfCakes * Cake.CalculateCakeCost() * 1.13;
        }

        //modified for lab 5
        public override string ToString()
        {
            return Customer.ToString() + "\nYou have ordered " + NumOfCakes + Cake.ToString() +
                " for the total cost of " + CalculateCostWithTax().ToString("C");
        }
    }
}
