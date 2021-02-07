using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(array);
            while(stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                if(symbol == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
