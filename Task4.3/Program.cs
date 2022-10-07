using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа - Количество квадратов на стороне прямоугольника");
            Console.WriteLine("Введите последовательно 3 положительных числа A, B и C");
            Console.Write("A=");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.Write("C=");
            int numberC = Convert.ToInt32(Console.ReadLine());
            
            int countA = 0; int countB = 0;
            int c1 = numberC; int c2 = numberC;
            while (c1 <= numberA)
            {
                countA++;
                c1 = c1 + numberC;
            }
            while (c2 <= numberB)
            {
                countB++;
                c2 = c2 + numberC;
            }
            int count = 1; int sum = 0;
            while (count <= countA )
            {
                count++;
                sum = sum + countB;
            }
            Console.WriteLine("В прямоугольник со сторонами A и B влезло квадратов со стороной С: {0}", sum);
            Console.ReadKey();
        }
    }
}
