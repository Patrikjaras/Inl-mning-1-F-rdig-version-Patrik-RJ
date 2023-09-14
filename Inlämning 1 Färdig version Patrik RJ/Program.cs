using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Färdig_version_Patrik_RJ
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("skriv in något");
            string input = Console.ReadLine();
            int TotalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char first = input[i];
                var endIndex = AndraPosition(input, first, i + 1);

                if (endIndex != -1)
                {
                    var length = endIndex - i + 1;
                    Console.WriteLine(input.Substring(i, length));
                    int sum = Convert.ToInt32(input.Substring(i, length));
                    TotalSum += sum;
                }
            }
            Console.WriteLine($"Total sum is: {TotalSum}");
            Console.ReadKey();
        }
        static int AndraPosition(string input, char first, int start)
        {
            if (char.IsLetter(first))
            {
                return -1;
            }
            for (int j = start; j < input.Length; j++)
            {
                if (first == input[j])
                {
                    return j;
                }
                if (char.IsLetter(input[j]))
                {
                    break;
                }
            }
            return -1;
        }
    }
    
}
