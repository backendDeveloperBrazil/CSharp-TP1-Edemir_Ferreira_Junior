﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número que deseja somar: ");
            var num1 = Console.ReadLine();


            Console.WriteLine("Informe o segundo número que deseja somar: ");
            var num2 = Console.ReadLine();

            decimal resultado = Convert.ToDecimal(num1) + Convert.ToDecimal(num2);


            Console.WriteLine($"A soma de {num1} e {num2} é = {resultado} ");

            Console.ReadLine();


        }
    }
}
