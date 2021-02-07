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
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numsInStack.Length ; i++)
            {
                stack.Push(numsInStack[i]);
            }
            for (int i = 0; i < array[1]; i++)
            {
                stack.Pop();
            }
            int[] isTrue = stack.ToArray();
            for (int i = 0; i < isTrue.Length; i++)
            {
                if (isTrue[i] == array[2])
                {
                    Console.WriteLine("true");
                    return;
                }

            }

            if(stack.Count > 0)
            {
                int[] smallestNum = stack.ToArray();
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
