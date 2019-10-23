using System;
using System.Collections.Generic;
using System.Text;

namespace lab3naladchikhas
{

    class Program
    {
        public static int GetMax(int[] array)
        {
            int a, b = 1, c = 0, i, z;
            int rez = array[0];
            Console.WriteLine("Введите порядковый номер числа: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < a; i++)
            {
                z = b;
                b = c + b;
                c = z;
            }
            rez = b;

            return rez;



        }
        static void Main(string[] args)
        {
            int i;
            int[] mas = new int[1000];
            int rez = GetMax(mas);
            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}