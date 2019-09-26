using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {

        static int prev;

        public static int GetRandom()
        {

            Random rnd = new Random(prev);

            prev = rnd.Next(-100, 100);


            return prev;
        }


        static void Main(string[] args)
        {
            //Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули.
            int a = 5;
            int b = 5;
            int c = 5;

            int[,,] mass = new int[a, b, c];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        mass[i, j, k] = GetRandom();
                        if (mass[i, j, k] > 0)
                            mass[i, j, k] = 0;
                       
                        Console.WriteLine(mass[i, j, k]);
                    }
                }
            }


            Console.ReadLine();

        }
    }
}
