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
            MyClass myClass = new MyClass(25);
            Console.WriteLine(myClass.PI());
            Console.WriteLine(myClass.Int());
            Console.WriteLine(myClass.Pow());
            Console.WriteLine(myClass.Sqrt());
        }
    }
}
