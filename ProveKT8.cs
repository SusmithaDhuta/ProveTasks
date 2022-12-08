using System;
using System.Collections;

namespace ProveTasks
{
    class ProveKT8
    {
        public static void Main(string[] args)
        {
            int total = 3;
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < total; i++)
            {

                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());

                arrayList.Add(new Person() { Name = name, Age = age });
            }

            Console.WriteLine("List of Person Name and Age in ArrayList :");
            foreach (Person p in arrayList)
            {
              Console.WriteLine ( p.ToString());
            }           
        }
          
    }
        public class Person
        {
           public string Name;
            public int Age;
            public override string ToString()
            {
                return Name + ":" + Age;
            }

        }   
}
