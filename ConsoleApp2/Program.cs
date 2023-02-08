using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> st2 = new Stack<string>();
            st2.Push("group");
            st2.Push("221");
            st2.Push("study");
            st2.Push("hello");
            st2.Push("group");
            st2.Push("are u ready");
            foreach (string st in st2)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("Второй список:");
            
            Stack<string> st3 = new Stack<string>();
            st3.Push("group");
            st3.Push("221");
            st3.Push("study");
            st3.Push("hello");
            st3.Push("group");
            st3.Push("are u ready");
            st3.Pop();
            st3.Pop();
            foreach (string se in st3)
            {
                Console.WriteLine(se);
            }
            

        }
    }
}
