using System;
using System.Collections.Generic;
using System.Text;

namespace ProveTasks
{
    public abstract class Animal
    {
        public string Name; // name property
        public void SetName(string name) // SetName method which takes string as parameter
        {
            Name = name;
        }
       public String GetName() // GetName method which returns string Name
        {
            return Name;

        }
        public abstract void Eat(); // abstract method which needs further Implementation
    }

    public class Dog : Animal //Dog class which is Inheriting from Animal class
    {
        public override void Eat() //overriding Eat method
        {
            Console.WriteLine("Eating");
        }
    }

    public class ProveKT4
    {
        public static void Main(string[] args) //Main method-entry point of program
        {
            Dog dog = new Dog(); // Instantiating Dog class
            dog.SetName(Console.ReadLine()); // Reading Input from user
            
            Console.WriteLine(dog.GetName()); // Printing the data
            dog.Eat();
        }
    }
}
