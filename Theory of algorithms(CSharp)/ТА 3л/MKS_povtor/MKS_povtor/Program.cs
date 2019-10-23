using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKS_povtor
{
    class Program
    {
        static void BucketSort(int[] mas)
        {
            List<int>[] lst = new List<int>[mas.Length];
            for (int i = 0; i < lst.Length; ++i)
                lst[i] = new List<int>();
            int min = mas[0];
            int max = mas[0];

            for (int i = 1; i < mas.Length; ++i)
            {
                if (mas[i] < min)
                    min = mas[i];
                else if (mas[i] > max)
                    max = mas[i];
            }
            double range = max - min;

            for (int i = 0; i < mas.Length; ++i)
            {
                int bcktIdx = (int)Math.Floor((mas[i] - min) / range * (lst.Length - 1));
                lst[bcktIdx].Add(mas[i]);
            }
            for (int i = 0; i < lst.Length; ++i)
                lst[i].Sort();
            int id = 0;

            for (int i = 0; i < lst.Length; ++i)
            {
                for (int j = 0; j < lst[i].Count; ++j)
                    mas[id++] = lst[i][j];
            }
        }

        static void Main()
        {

            Console.WriteLine("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < mas.Length; ++i)
                mas[i] = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine(String.Join(" ", mas));
            BucketSort(mas);
            Console.WriteLine(String.Join(" ", mas));
            Console.ReadKey();
        }
    }
}
