using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {

        public static void BubbleSort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
        }

        public static int Max_size (int [] Array)
        {
            int maxim = Array[0];
            for (int i = 1; i< Array.Length;i++ )
            {
                if (Array[i] > maxim)
                    maxim = Array[i];
            }
            return maxim;
        }

        public static int Min_size(int[] Array)
        {
            int minim = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] < minim)
                    minim = Array[i];
            }
            return minim;
        }




        static int prev;
        
        public static int GetRandom()
        {
            
            Random rnd = new Random(prev);

            prev = rnd.Next(-100, 100);

            
            return prev;
        }


        static void Main(string[] args)
        {
            //Задание 1
            //Написать программу, которая генерирует случайным образом элементы массива(число элементов в массиве и их тип определяются разработчиком), 
            //определяет для него максимальное и минимальное значения, сортирует массив и выводит полученный результат на экран.
            //Примечание: LINQ запросы и готовые функции языка(Sort, Max и т.д.) использовать в данном задании запрещается.

            int size = 8;
            int[] mass = new int[size];
            int max, min;
                       
            Console.WriteLine("Массив случайных чисел из "+size+ "  элементов");

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = GetRandom();

                Console.WriteLine(mass[i]);

            }

            BubbleSort(mass);
            max = Max_size(mass);
            min = Min_size(mass);
            Console.WriteLine("Максимальный элемент массива  "+ max);
            Console.WriteLine("Минимальный элемент массива  "+ min);


            Console.ReadLine();

        }
    }
}
