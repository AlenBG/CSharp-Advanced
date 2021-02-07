using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);
            string input = Console.ReadLine();
            while(queue.Count > 0)
            {
                List<string> command = input.Split().ToList();
                if(command[0] == "Play")
                {
                    queue.Dequeue();
                }
                if(command[0] == "Add")
                {
                    List<string> listed = queue.ToList();
                    
                    command.Remove("Add");
                    if (listed.Contains(command[0]))
                    {
                        Console.WriteLine($"{String.Join(' ', command)} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(String.Join(' ', command));
                    }
                }
                if(command[0] == "Show")
                {
                    List<string> listOfSongs = new List<string>();
                    Queue<string> queue2 = new Queue<string>(queue);
                    for (int i = 0; i < queue.Count; i++)
                    {
                        listOfSongs.Add(queue2.Dequeue());
                    }
                    Console.WriteLine(String.Join(", ", listOfSongs));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
