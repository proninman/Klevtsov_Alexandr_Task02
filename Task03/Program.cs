using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3
            //Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве.
            int[] mass =  { 5, 18, 21, -34, 48 };
            int sum = 0;
            for (int i=0; i<mass.Length;i++)
            {
                if (mass[i] > 0)
                    sum = sum + mass[i];
            }
            Console.WriteLine("Сумма неотрицательных элементов массива равна "+sum);
            Console.ReadLine();


        }
    }
}
