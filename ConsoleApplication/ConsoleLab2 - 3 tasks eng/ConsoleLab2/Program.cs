using System;

namespace ConsoleLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////
            /////Task 1/////
            ////////////////

            /*
            string N;
            Console.WriteLine("Enter the number of the month:");
            do
            {
                N = Console.ReadLine();
                switch (N)
                {
                    case "1":
                        Console.WriteLine("YAN");
                        break;
                    case "2":
                        Console.WriteLine("FEV");
                        break;
                    case "3":
                        Console.WriteLine("MAR");
                        break;
                    case "4":
                        Console.WriteLine("APR");
                        break;
                    case "5":
                        Console.WriteLine("MAI");
                        break;
                    case "6":
                        Console.WriteLine("IUN");
                        break;
                    case "7":
                        Console.WriteLine("IUL");
                        break;
                    case "8":
                        Console.WriteLine("AVG");
                        break;
                    case "9":
                        Console.WriteLine("SEN");
                        break;
                    case "10":
                        Console.WriteLine("OKT");
                        break;
                    case "11":
                        Console.WriteLine("NOV");
                        break;
                    case "12":
                        Console.WriteLine("DEC");
                        break;
                    default:
                        Console.WriteLine("Enter a natural number from 1 to 12");
                        break;
                }
            } while (N != "1" || N != "2 " || N != "3" || N != "4" || N != "5" || N != "6" || N != "7" || N != "8" || N != "9"
            || N != "10" || N != "11" || N != "12");
            Console.ReadKey();*/

            ////////////////
            /////Task 2/////
            ////////////////

            /*int i, k, a = 0;
            double sred;
            Console.WriteLine("Enter array size: ");
            k = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[k];
            Console.WriteLine("Enter an array: ");
            for (i = 0; i < k; i++)
                mas[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < k; i++)
                a = a + mas[i];
            sred = (double)a / (double)k;
            Console.Write("Mean value = ");
            Console.WriteLine(sred);
            Console.ReadKey();*/

            ////////////////
            /////Task 3/////
            ////////////////

            /*double a = 10, sum = 10;
            int k = 1;
            do
            {
                a = a + (a / 100 * 10);
                sum = sum + a;
                k++;
            }
            while (sum < 100);
            Console.WriteLine("100 km will exceed in " + k + " days");
            Console.ReadKey();*/
        }
    }
}
