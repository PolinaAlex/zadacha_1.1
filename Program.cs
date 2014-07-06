using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение полного сопротивления соединения, который состоит из трех проводников соединенных последовательно.");
            Console.WriteLine("Введите R1:");
            Double r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите R2:");
            Double r2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите R3:");
            Double r3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Полное сопротивление соединения={0}", r1 + r2 + r3);

            Console.ReadKey();
        }
    }
}
