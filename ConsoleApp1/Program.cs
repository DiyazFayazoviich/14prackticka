using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> st2 = new Stack<double>();
            st2.Push(-5.2);
            st2.Push(72.3);
            st2.Push(2.3);
            st2.Push(18.4);
            st2.Push(-16.3);
            Console.WriteLine(st2.Max());
            

        }
    }
}
