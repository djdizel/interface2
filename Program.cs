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
            Person myClass = new Person();
            Console.WriteLine(myClass.Method() + myClass.Method4());
            Console.WriteLine(myClass.Method2() + myClass.Method5());
            Console.WriteLine(myClass.Method3() + myClass.Method6());
        }
    }
}
