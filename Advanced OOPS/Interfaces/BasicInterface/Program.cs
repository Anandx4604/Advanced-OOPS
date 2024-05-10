using System;
namespace BasicInterface;
class Program
{
   public static void Main(string[] args)
   {
        Dog dog = new Dog();
        dog.animalSound();
        Cat cat = new Cat();
        cat.animalSound();
        Horse horse = new Horse();
        horse.animalSound();
   } 
}
