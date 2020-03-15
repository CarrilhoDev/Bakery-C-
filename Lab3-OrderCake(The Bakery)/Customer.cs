using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer()
        {
            FirstName = LastName = string.Empty;
        }

        public Customer(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public override string ToString()
        {
            return "Thank you " + FirstName + " " + LastName + " !!";
        }
    }
}
