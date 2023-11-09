using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0,t=1;
            Console.WriteLine("Fibonacci Series");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(s);
                int temp = s;
                s = t;
                t = temp + t;
                
            }
            Console.ReadKey();
        }
    }
}
