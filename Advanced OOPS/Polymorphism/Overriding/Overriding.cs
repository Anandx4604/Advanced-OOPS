using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Overriding
{
    public class Animal
    {
        public virtual string Sound()
        {
            return "Animal Sound";
        }
    }

    public class Dog : Animal
    {
        public override string Sound()
        {
            return "Woof! Woof!";
        }
    }

     public class Pomerian: Dog
    {
        public override string Sound()
        {
            return "Bow! Bow!";
        }
    }


}