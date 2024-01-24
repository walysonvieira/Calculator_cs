using Microsoft.VisualBasic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao();
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
            // Menu();
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
            // Menu();
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
            // Menu();
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
            // Menu();
        }
    }
}
