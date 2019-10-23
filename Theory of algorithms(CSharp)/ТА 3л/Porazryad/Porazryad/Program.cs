﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porazryad
{
    class Program
    {
        public static void RadixSorting(int[] mas, int range, int n)
        {
            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();
            for (int step = 0; step < n; ++step)
            {
                for (int i = 0; i < mas.Length; ++i)
                {
                    int a = (mas[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[a].Add(mas[i]);
                }
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        mas[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < mas.Length; ++i) {
            mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(double x in mas) {
            Console.Write(x + " ");
            }
            RadixSorting(mas, 10, 2);
            Console.WriteLine(" ");
            foreach (double x in mas) {
            Console.Write(x + " ");
            }
            System.Console.ReadKey();
        }
    }
}
