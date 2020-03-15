using System;
using System.Collections.Generic;

namespace CakeClasses
{
    public class CharacterCake : Cake
    {
        public string CharCake { get; set; }
        
              
        public CharacterCake() { }

        public CharacterCake(string flavour, double numOfLayers, string charCake)
            : base(flavour, numOfLayers)
        {
            CharCake = charCake;
            DefineCharCake(charCake);
        }
    
        public string DefineCharCake(string charCake)
        {
            string[] splittedString = charCake.Split('$');
            Price = Convert.ToDouble(splittedString[1]);
            return splittedString[0].ToString();
        }

        
        public override string ToString()
        {
            return "1 " + DefineCharCake(CharCake) + base.ToString();
        }

                           
    }
}
