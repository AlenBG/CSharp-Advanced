using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] input = command.Split();
                string firstWord = input[0].ToLower();
                if(firstWord == "end")
                {
                    break;
                }
                if(firstWord == "add")
                {
                    int firstNum = int.Parse(input[1]);
                    int secondNum = int.Parse(input[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                if(firstWord == "remove")
                {
                    
                    int n = int.Parse(input[1]);
                    if (stack.Count > n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine();
            }
            int sum = 0;
            foreach  (int num in stack)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
