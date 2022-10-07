using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа последовательность + и - чисел");
            Console.WriteLine("Вводите целые числа. Программа завершится, когда будет введено число 0.");
            int number;
            int positiveCount = 0;
            int negativeCount = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0) positiveCount++;
                else if (number < 0) negativeCount++;

            } while (number!= 0);

            if (negativeCount > positiveCount) Console.WriteLine("Отрицательных ({0}) больше чем положительных ({1})", negativeCount,positiveCount);
            else if (negativeCount < positiveCount) Console.WriteLine("Положительных ({0}) больше чем отрицательных ({1})", positiveCount, negativeCount);
            Console.ReadKey();
        }
    }
}
