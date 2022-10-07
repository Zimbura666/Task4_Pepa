using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    internal class ProgramFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисления квдрата числа по формуле");
            Console.WriteLine("Введите целое число N > 0");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1 ; i <= (2*n-1); i=i+2)
            {               
                sum = sum + i;                
               if (i<( 2 * n - 1)) Console.WriteLine(sum);
            }
            Console.WriteLine("{0} - квадрат числа N",  sum);
            Console.ReadKey();
        }
    }
}
