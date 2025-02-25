// Written by Chloe Jensrud
// 2/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{ // dog subclass
    public class Dog : Animal
    {
        public override string ToString()
        {
            return "Bark";
        }
    }

    //cat subclass
    public class Cat : Animal
    {
        public override string ToString()
        {
            return "Meow";
        }
    }
}
