using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(array);
            int numberOfBoxes = 0;
            int currentSum = 0;
            int boxCapacity = int.Parse(Console.ReadLine());
            while(stack.Count > 0)
            {
                if(currentSum + stack.Peek() <= boxCapacity)
                {
                    currentSum += stack.Pop();
                }
                else
                {
                    currentSum = 0;
                    numberOfBoxes++;
                }
            }
            if(currentSum > 0)
            {
                numberOfBoxes++;
            }
            Console.WriteLine(numberOfBoxes);
        }
    }
}
