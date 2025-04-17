using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass : IInterface
    {
        int num;

        public int Num { get => num; set => num = value; }

        public MyClass(int num) 
        {
            this.Num = num;
        }
        public double PI()
        {
           return Math.PI;
        }
        public int Int()
        {
            return Num;
        }

        public double Pow()
        {
            return Math.Pow(2, Num);
        }

        public double Sqrt()
        {
            return Math.Sqrt(Num);
        }
    }
}
