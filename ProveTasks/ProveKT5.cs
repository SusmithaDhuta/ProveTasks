using System;
using System.Collections.Generic;
using System.Text;

namespace ProveTasks
{
    class ProveKT5
    {
        public static void Main(string[] args)
        {
            int sum = 10; 
            int[] numbers = new int[sum]; // defining number of interger elements in array
            for (int i = 0; i < sum; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine()); // storing the user inputs in array called numbers
            }
            Console.WriteLine("The List of even Numbers from Integer Array:");

            for (int i=0; i < sum; i++) //for loop for iterations
            {
                if (numbers[i] %2 == 0)  //Logic for sorting the even numbers from array list
                {                 
                  Console.WriteLine("{0}", numbers[i]); // printing the even numbers after sorting
                }
            }
        }
    }
}
