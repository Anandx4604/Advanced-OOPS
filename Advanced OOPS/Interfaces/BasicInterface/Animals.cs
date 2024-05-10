using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicInterface
{
    public class Dog:IAnimal //implements interface Ianimal here
    {
        public void animalSound()
        {
            //body of that method 
            System.Console.WriteLine("Dog says: Woof! Woof!");
        }
    }

    public class Cat:IAnimal
    {
        public void animalSound()
        {
        System.Console.WriteLine("Cat says: Meow! Meow!");
        }
    }

    public class Horse: IAnimal
    {
        public void animalSound()
        {
            System.Console.WriteLine("Horse say: Neigh! Neigh!");
        }
    }

}