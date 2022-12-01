using System;

namespace ProveTasks
{
    public class InheritanceTask2
    {

        public static void Main(string[] args)  // Main Method- entry point of a program
        {
            int total = 3;
            Person[] persons = new Person[total];  // user defined type array(Class Array) for storing person names

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());  // reading person names from user and storing in Person class array on Condition based
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine()); // store the user names in Person Class array on condition
                }
            }
            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();   // calling child class method

                }
                else
                {
                    ((Student)persons[i]).Study();   // calling child class method
                }
            }
        }

        public class Person   //creating person class
        {
            protected string Name { get; set; }  // protected access modifier for Name property so child classes can access

            public Person(string name)  //constructor that takes name as parameter
            {
                Name = name;
            }

            public override string ToString()
            {
                return "Hi! My name is " + Name;
            }

            ~Person() //Destructor to empty the memory
            {
                Name = string.Empty;
            }
        }

        public class Teacher : Person // Teacher(Child) class Inhering from Person(Parent) class
        {
            public Teacher(string name) : base(name) // child class constructor calling parent class constructor
            {
                Name = name;
            }

            public void Explain()
            {
                Console.WriteLine("Explain");
            }
        }

        public class Student : Person  //Student (Child) class Inhering from Person(Parent) class
        {
            public Student(string name) : base(name) // child class constructor calling parent class constructor
            {
                Name = name;
            }

            public void Study() 
            {
                Console.WriteLine("Study");
            }
        }
    }
}
