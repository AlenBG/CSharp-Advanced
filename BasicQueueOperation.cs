using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numsInStack = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numsInStack.Length ; i++)
            {
                queue.Enqueue(numsInStack[i]);
            }
            for (int i = 0; i < array[1]; i++)
            {
                queue.Dequeue();
            }
            int[] isTrue = queue.ToArray();
            for (int i = 0; i < isTrue.Length; i++)
            {
                if (isTrue[i] == array[2])
                {
                    Console.WriteLine("true");
                    return;
                }

            }

            if(queue.Count > 0)
            {
                int[] smallestNum = queue.ToArray();
                int smallNum = smallestNum[0];
                for (int i = 1; i < smallestNum.Length; i++)
                {
                    if (smallNum > smallestNum[i])
                    {
                        smallNum = smallestNum[i];
                    }
                }
                Console.WriteLine(smallNum);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
