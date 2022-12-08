using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;//Размер массива
            int i, x = 0;//Переменные
            int[] mas = new int[n];
            //Заполнение массива случайными числами
            Random rnd = new Random();
            for (i = 0; i < n; i++)
                mas[i] = rnd.Next(-10, 10);
            //Числа, на нечетных местах
            int c = 0;
            for (i = 0; i < n; i++)
            {
                if (mas[i] % 2 == 0)
                    c = mas[i];
            }
            for (int j = 0; j < n - 1; j++)

                if (mas[j] > mas[j + 1])
                {
                    x = mas[j];
                    mas[j] = mas[j + 1];
                    mas[j + 1] = x;
                }
            Console.WriteLine("Исходный массив:");

            for (i = 0; i < n; i++)
                Console.Write(mas[i] + "; ");
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            for (int j = 0; j < n; j++)
                Console.Write(c + "; ");
            Console.ReadLine();//Пауза

        }
    }
}
