using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(array);
            Console.WriteLine(queue.Max());
            while(queue.Count > 0)
            {
                if(quantity >= queue.Peek())
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    int[] array1 = queue.ToArray();
                    Console.WriteLine($"Orders left: {String.Join(' ', array1)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
