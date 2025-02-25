// Written by Chloe Jensrud
// 2/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{ // base class
    public class Animal
    { // class variables
        private string name = "n/a";

        // gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        //empty constructor
        public Animal() : this("n/a")
        {

        }
        // full constructor
        public Animal(string aName)
        {
            this.Name = aName;
        }

        public string MakeSound()
        {
            return "Some generic animal sound.";
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Animal: {name}, Sound: {MakeSound}";
            return msg;
        }
    }
}
