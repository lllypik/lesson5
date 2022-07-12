using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для запуска программы нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine();
            int lengthArray = 15;
            int[] array = new int[lengthArray];
            Random random = new Random();
            int max = 0;
            int min = 0;
            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = random.Next(0,50);
                Console.WriteLine("{0,4}",array[i]);
                if (max < array[i]) max = array[i];
                if (min > array[i]) min = array[i];
            }
            int summ = min + max;
            Console.WriteLine("Минимальное число массива " + min );
            Console.WriteLine("Максимальное число массива " + max);
            Console.WriteLine("Сумма минимального и минимального чисел "+ summ);
            Console.ReadKey();

        }
    }
}
