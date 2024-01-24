﻿using Microsoft.VisualBasic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
         static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");


            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");
            short selectOperator = short.Parse(Console.ReadLine());

            switch (selectOperator)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Escolha um operador!"); break;
            }
            Menu();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float RSoma = v1 + v2;
            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da soma é: {RSoma}");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float Rsubtracao = v1 - v2;
            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da subtração é: {Rsubtracao}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float Rdivisao = v1 / v2;
            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da divisão é: {Rdivisao}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float Rmultiplicacao = v1 * v2;
            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da multiplicação é: {Rmultiplicacao}");
            Console.ReadKey();
            Menu();
        }
    }
}
