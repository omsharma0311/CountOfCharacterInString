using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfCharacterInString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your String:");
            var inputString = Console.ReadLine();
            Console.WriteLine("Input String = {0}", inputString);
            var uniqueCharArray = inputString.ToCharArray().Distinct().Where(e => e != ' ').ToArray();
            

            for (int i = 0; i < uniqueCharArray.Length; i++)
            {
                int count = 0;
                char alphabet = uniqueCharArray[i];
                for (int j = 0; j < inputString.Length; j++)
                  if (alphabet == inputString[j])
                     count++;
                Console.WriteLine("Count of {0} is {1}", alphabet, count);
            }
        }
    }
}
