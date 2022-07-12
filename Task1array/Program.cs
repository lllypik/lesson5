using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы одномерного массива из 7 элементов");
            int lengthArray = 7;
            int[] array = new int[lengthArray];
            double summ = 0;
            double average;
            for (int i = 0; i < lengthArray; i++)
             {
                array[i] = Convert.ToInt32(Console.ReadLine());
                summ +=array[i];
             };
            average = summ / array.Length;
            Console.WriteLine("Cреднее арифметическое элементов массива - "+average);
            Console.ReadLine();

        }
    }
}
