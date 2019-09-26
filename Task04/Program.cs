using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            //Элемент двумерного массива считается стоящим на чётной позиции, если сумма номеров его позиций по обеим размерностям 
            //является чётным числом(например, [1,1] –чётная позиция, а[1, 2] -нет).  
            //Определить сумму элементов массива, стоящих на чётных позициях.

            
            int[,] mass = new int[3, 2] { {6, 0},
                                          {5, 7},
                                          {8, 9} };
            int sum = 0;
            for (int j=0; j<2;j++)
            {
                for (int i=0; i<3; i++)
                {
                    if ((i + j) % 2 == 0)
                        sum = sum + mass[i, j];
                }

            }

            Console.WriteLine("Сумма элементов массива, стоящих на чётных позициях равна " + sum);
            Console.ReadLine();


        }

    }
}
