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
            Console.WriteLine("1. Ввести А\n2. Ввести В\n3. Выполнить операцию +\n4. Выполнить операцию -\n5. Выполнить операцию *\n6. Выполнить операцию /");
            Console.WriteLine("Выберите операцию ");


            int r = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 0;
            if (r == 1)
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            if (r == 2)
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            if (r == 3)
            {
                Console.WriteLine(a + b);
            }
            if (r == 4)
            {
                Console.WriteLine(a - b);
            }
            if (r == 5)
            {
                Console.WriteLine(a * b);
            }
            if (r == 6)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
