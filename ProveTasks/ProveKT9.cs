using System;
using System.Collections.Generic;
using System.Text;

namespace ProveTasks
{
    class ProveKT9
    {
        public static void Main(string[] args)
        {
            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());
            int total=0;

            for(int i=0;i<Number2;i++)
            {
                total = total+ Number1;
            }
            Console.WriteLine("The Multiplication of Two Numbers:{0}", total);
        }
    }
}
