using System;
using System.Collections.Generic;
using System.Text;

namespace ProveTasks
{
    class ProveKT6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            if (IsNumber(text))
            {
                Console.WriteLine("Is Number");

            }
            else
            {
                Console.WriteLine("Is Not a Number");
            }
        }


        public static bool IsNumber(string text)
       
           {

            for (int i = 0; i<text.Length; i++)
            {
                if (char.IsDigit(text[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

     }
  }

