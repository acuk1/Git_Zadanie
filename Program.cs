﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    class Program
    {
        /*
         * ЯХА
         * ЯХА
        static int Max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
       */
        static double Ctg(double a)
        {
          return (Math.Cos(a) / Math.Sin(a));
        }
        static void Main(string[] args)
        {
            /*Max(3, 10, 8);
            Console.WriteLine($"макс число: " + Max(3,5,8));*/
            Console.WriteLine($"Это реально круто: " + Ctg(10));
        }
    }
}
