﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int m;
            Console.Write("informe o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("informe o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("informe o terceiro valor: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("informe o quarto valor: ");
            d = int.Parse(Console.ReadLine());
            m = (a + b + c + d) / 4;
            Console.Write("o valor da média é: ");
            Console.Write(m);
            
        }
    }
}
