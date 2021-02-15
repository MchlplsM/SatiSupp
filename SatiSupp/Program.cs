using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatiSupp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTxtFile = @"input.txt";
            int a;
            int b;
            string ab, range;

            if (File.Exists(inputTxtFile))
            {
                string[] numberLines = File.ReadAllLines(inputTxtFile);
                ab = numberLines[0];
                range = numberLines[1];
                string[] splitAB = ab.Split(' ');
                string[] splitRange = range.Split(' ');
                a = Convert.ToInt32(splitAB[0]);
                b = Convert.ToInt32(splitAB[1]);
                int firstPartOfRange = Convert.ToInt32(splitRange[0]);
                int secondPartOfRange = Convert.ToInt32(splitRange[1]);

                int counter = 0;
                for (int i = firstPartOfRange; i < secondPartOfRange; i++)
                {
                    if (i % a == 0 && i % b !=0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The amount of numbers that satisfy the objective are: {counter}");

                counter = 0;
                for (int i = firstPartOfRange; i < secondPartOfRange; i++)
                {
                    if (i % a != 0 && i % b == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The amount of numbers that satisfy the objective are: {counter}");

                counter = 0;
                for (int i = firstPartOfRange; i < secondPartOfRange; i++)
                {
                    if (i % a == 0 && i % b == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The amount of numbers that satisfy the objective are: {counter}");

                counter = 0;
                for (int i = firstPartOfRange; i < secondPartOfRange; i++)
                {
                    if (i % a != 0 && i % b != 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The amount of numbers that satisfy the objective are: {counter}");

            };

        }
    }
}
