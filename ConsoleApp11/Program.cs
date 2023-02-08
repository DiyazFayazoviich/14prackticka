using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int> ();
            int cunt = 0;
            Random dvach = new Random();
            for (int i = 1; 1 <= 10; i++)
            {
                queue.Enqueue(dvach.Next(-5, 20));
                Console.WriteLine(i + ")" + queue.Peek());
            if (queue.Peek() < 10) cunt++;
            queue.Dequeue();
            queue.TrimExcess();
        }
            Console.WriteLine("Кол-во элеметнов меньше");
            Console.ReadKey();



        }
    }
}
