using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3_zavd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть, будь ласка, натуральне число n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ви ввели число: " + n);

            if (n > 0)
            {
                double sum = 0;

                for (int i = 1; i <= n; i++) // Починаємо з 1, щоб уникнути ділення на нуль
                {
                    sum += 1.0 / i;
                }

                Console.WriteLine($"Сума s = {sum}");
            }
            else
            {
                Console.WriteLine("На жаль, введене число значення n не є допустимим натуральним числом");
            }
        }
    }
}
