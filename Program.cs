using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main (string[] args)
        {
            // 10 var

            //Random rnd = new Random();
            //int m, n, k;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите кол-во строк массива");
            //        m = Convert.ToInt32(Console.ReadLine());
            //        if (m > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите кол-во столбцов массива");
            //        n = Convert.ToInt32(Console.ReadLine());
            //        if (n > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите на какой строке найти сумму и произведение элементов");
            //        k = Convert.ToInt32(Console.ReadLine());
            //        if (k > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //int[,] numbers = new int[m, n];
            //int[] remember1 = new int[m];
            //int[] remember2 = new int[m];
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    int sum = 0;
            //    int proiz = 1;
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        numbers[i, j] = rnd.Next(0, 25);
            //        Console.Write($"{numbers[i, j],5} ");
            //        sum = sum + numbers[i, j];
            //        proiz = proiz * numbers[i, j];
            //    }
            //    remember1[i] = sum;
            //    remember2[i] = proiz;
            //    Console.WriteLine();
            //}
            //for (int i = k - 1; i < k; i++)
            //{
            //    Console.WriteLine($"Сумма {k} строки : {remember1[i]}");
            //    Console.WriteLine($"Произведение {k} строки : {remember2[i]}");
            //}

            // 7 var

            //Random rnd = new Random();
            //int m, n, k, d, t;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите кол-во строк массива");
            //        m = Convert.ToInt32(Console.ReadLine());
            //        if (m > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите кол-во столбцов массива");
            //        n = Convert.ToInt32(Console.ReadLine());
            //        if (n > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите в каком столбце найти элементы больше 15-ти");
            //        k = Convert.ToInt32(Console.ReadLine());
            //        if (k > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите в какой строке найти среднее арифм. нечетных элементов");
            //        d = Convert.ToInt32(Console.ReadLine());
            //        if (d > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите в каком столбце найти среднее арифм. элеменов кратных четырем");
            //        t = Convert.ToInt32(Console.ReadLine());
            //        if (t > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введено неверно");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Введено неверно");
            //    }
            //}
            //int count = 0; int doublemed = 0; double sum = 0; double medium = 0;
            //int[,] numbers = new int[m, n];
            //int[] remember1 = new int[m];
            //int[] remember2 = new int[m];
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        numbers[i, j] = rnd.Next(0, 25);
            //        Console.Write($"{numbers[i, j],5} ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int j = k - 1; j < k; j++)
            //{
            //    for (int i = 0; i < numbers.GetLength(0); i++)
            //    {
            //        if (numbers[i,j] > 15)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine($"Кол-во элементов в {k} столбце больше 15 : {count}");
            //for (int i = d - 1; i < d; i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        if (!(numbers[i, j] % 2 == 0))
            //        {
            //            sum = sum + numbers[i, j];
            //            doublemed++;
            //        }
            //    }
            //    medium = sum / doublemed;
            //}
            //Console.WriteLine($"Среднее арифметическое нечетных элементов в {d} строке : {medium}");
            //sum = 0; doublemed = 0;
            //for (int j = t - 1; j < t; j++)
            //{
            //    for (int i = 0; i < numbers.GetLength(0); i++)
            //    {
            //        if (numbers[i, j] % 4 == 0)
            //        {
            //            sum = sum + numbers[i, j];
            //            doublemed++;
            //        }
            //    }
            //    medium = sum / doublemed;
            //}
            //Console.WriteLine($"Среднее арифметическое элементов кратных четырем в {t} столбце : {medium}");
        }
    }
}
