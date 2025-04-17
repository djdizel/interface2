using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person : Interface1 , Interface2
    {
        public string Method()
        {
            return ("Говорит громко - ");
        }
        public string Method2() 
        {
            return "Думает - ";
        }
        public string Method3()
        {
            return "Говорит нормально - ";
        }
        public string Method4()
        {
            return "Я люблю программирование!";
        }
        public string Method5()
        {
            return "А С# больше всего";
        }
        public string Method6()
        {
            return "Меньше я люблю компьютерные игры";
        }
    }
}
