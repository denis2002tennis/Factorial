﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {


                Console.WriteLine("Введите число. Вычислить факториал числа");
                int factorial = Convert.ToInt32(Console.ReadLine());
                int a = factorial;
                int answer = 1;
                for (int i = 1; i <= factorial; ++i)
                {
                    answer *= i;
                }
                Console.WriteLine("Факториал " + factorial + " это " + answer);
            }
            
        }
    }
}

