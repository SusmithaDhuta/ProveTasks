using System;
namespace ProveTasks
{ 
    public class ProveKT1
    {
    public static void Main(string[] args) // Main Method- entry point of a program
    {
        int total = 3;
        Person[] persons = new Person[total]; // user defined type array for storing person names

        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine()); // reading person names from user
        }

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString()); // printing the persons names
        }
    }

        public class Person
        {
            public string Name { get; set; }  // Defining Name Proprty of type string

            public Person(string name) // Defining constructor which takes string name as parameter
            {
                Name = name;
            }

            public override string ToString() // overriding the string
            {
                return "Hello! My name is " + Name;
            }

            ~Person() // Destructor to empty the memory
            {
                Name = string.Empty;
            }
        }
    }
}
