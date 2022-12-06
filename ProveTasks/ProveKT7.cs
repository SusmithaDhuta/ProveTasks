using System;
using System.IO;

namespace ProveTasks
{
    class ProveKT7
    {
        public static void Main(string[] args)
        {
            string inputFileName = "input.txt"; 
            string outputFileName = "output.txt";

            string contents = File.ReadAllText(inputFileName);
            contents = contents.ToUpper();

            File.WriteAllText(outputFileName, contents);
        }
    }
}
