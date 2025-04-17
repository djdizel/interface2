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
            List<PersonalComputer> PC = new List<PersonalComputer>();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Включить - 1\nВыключить - 0"); 
                int Switch = int.Parse(Console.ReadLine());
                if (Switch == 1)
                {
                    PC[i].On();
                }
                if (Switch == 2)
                {
                    PC[i].Off();
                }
                else
                {
                    Console.WriteLine("Неправильный ввод");
                }
            }
            Console.WriteLine();
        }
    }
}
