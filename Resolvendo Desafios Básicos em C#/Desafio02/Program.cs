﻿using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long resposta = (N*(N - 3)) / 2;
            Console.WriteLine(resposta);
        }
    }
}
