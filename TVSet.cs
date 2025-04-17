using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TVSet : ISwitchable
    {
        public void On()
        {
            Console.WriteLine("Включено");
        }
        public void Off()
        {
            Console.WriteLine("Выключено");
        }
    }
}
