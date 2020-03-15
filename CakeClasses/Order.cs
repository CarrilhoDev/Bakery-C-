using System.Collections.Generic;

namespace CakeClasses
{
    public class Order
    {
        
        public double Tax { get; set; } = 1.13;
        public List<Cake> ListOfCakes { get; set; }
        public Customer Customer { get; set; }
       


        public Order()
        {
            ListOfCakes = new List<Cake>();
            Customer = new Customer();
            
        }

     

        public void ClearList()
        {
            ListOfCakes.Clear();
        }


        public double CalculateCost()
        {
           double orderFinalPrice = 0;
            
            if(ListOfCakes?.Count > 0)
            {
                foreach(Cake cake in ListOfCakes)
                {
                    orderFinalPrice += cake.CakeCost() * Tax;
                }
            }
           
            return orderFinalPrice;
        }


        public void AddCake(Cake cake)
        {
            ListOfCakes.Add(cake);
        }

      
        public override string ToString()
        {
            string output = "";
            output += "Thank you " + Customer.ToString() + "!!\n" + "See your order: \n\n Your cake list has ";
                if(ListOfCakes.Count == 1)
            {
                output += ListOfCakes.Count.ToString() + " cake \n\n";
            }
                else if(ListOfCakes.Count > 1)
            {
                output += ListOfCakes.Count.ToString() + " cakes \n\n";
            }
                
                     
                   foreach (Cake cake in ListOfCakes)
                {
               
                output += cake.ToString() + "at the cost of: " + cake.CakeCost().ToString("c") + ". \n\n";
                
                }
                                         
            return output + "\n\n" + "The Total cost of your order is (with taxes): " + CalculateCost().ToString("c");

        }
        
    }
}
