using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci

            int loopLength = 20;
            int[] numbers = new int[loopLength+1];
            numbers[0] = 0;
            numbers[1] = 1;

            Console.WriteLine(0 + " : " + 0);
            Console.WriteLine(1 + " : " + 1);

            for (int i = 2; i <= loopLength; i++)
            {
                numbers[i] = numbers[i-1] + numbers[i-2];
                Console.WriteLine(i + " : " + numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
