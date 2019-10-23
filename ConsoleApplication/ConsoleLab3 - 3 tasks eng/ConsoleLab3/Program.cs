using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class Program
    {
        ////////////////
        /////Task 1/////
        ////////////////
        /*
        public static void GetMax(int[] array)
        {
            int k, i;
            int rez = array[0];
            Console.WriteLine("Enter the number you want to replace: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < array.Length; i++)
                if (array[i] == k)
                    array[i] = -k;
            Console.WriteLine("Processed array:");
            for (i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
        static void Main(string[] args)
        {
            int a, i;
            Console.WriteLine("Enter array size: ");
            a = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[a];
            Console.WriteLine("Enter an array: ");
            for (i = 0; i < a; i++)
                mas[i] = Convert.ToInt32(Console.ReadLine());
            GetMax(mas);
            Console.ReadKey();
        }*/

        ////////////////
        /////Task 2/////
        ////////////////

        /*static void Main(string[] args)
        {
            int i, j;
            double[,] mas = new double[4, 4];
            Console.WriteLine("Enter matrix:");
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Source matrix:");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write(mas[i, j] + "\t");
                Console.WriteLine();
            }
            double sum = 0;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (i == j)
                        sum = sum + mas[i, j];
                }
            }
            Console.WriteLine("The sum of the main diagonal = " + sum);
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    mas[i, j] = mas[i, j] / sum;
                }
            }
            Console.WriteLine("Transformed matrix:");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write(mas[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }*/

        ////////////////
        /////Task 3/////
        ////////////////

        /*public static int GetMax(int[] array)
        {
            int a, b = 1, c = 0, i, z;
            int rez = array[0];
            Console.WriteLine("Enter the sequence number: ");
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
        }*/
    }
}
