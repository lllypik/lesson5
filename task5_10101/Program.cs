using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_10101
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите размерность массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = (((i + j)%2==1) && true ) ? 1 : 0; //проверяем по четности суммы индексов ячеек. Если сумма нечетная, то 1, если четная - 0
                    Console.Write("{0}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
