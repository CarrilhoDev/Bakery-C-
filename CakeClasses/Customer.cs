using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Customer
    {

        public Customer() 
        {
            FirstName = "";
            LastName = "";
        }

        public Customer(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

       
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }



    }
}
