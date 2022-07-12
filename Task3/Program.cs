using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для запуска программы нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine();

            const int lengthArray = 10;
            int[] array = new int[lengthArray];
            Random random = new Random();


            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.WriteLine("{0,4}", array[i]);
            }

            int range5 = 5;

            //сортировка 0-4
            for (int i = 0; i < range5-1; i++)
            {
                for (int j = i + 1; j < range5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            //сортировка 5-10

            for (int i = range5; i < lengthArray-1; i++)
            {
                for (int j = i + 1; j < lengthArray; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив. Элементы от 0 до 4 по возрастанию, от 5 до 10 по убыванию ");
            for (int i = 0; i < lengthArray; i++)
            {
                Console.WriteLine("{0,4}", array[i]);
            }

            Console.ReadKey();
        }
    }
}
