using System;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
            double v1, v2;
        
            Console.WriteLine("Valor 01 :");
            v1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 02 :");
            v2 = Double.Parse(Console.ReadLine());
            string opcao;
            Console.WriteLine("Qual opcão ['-', '+', '/', '*', '%']:");
            opcao = Console.ReadLine();
            switch (opcao) {
            case ("-"):
            Console.WriteLine("----------------------------");
            Console.WriteLine(v1 - v2);
            break;
            case ("+"):
            Console.WriteLine("----------------------------");
            Console.WriteLine(v1 + v2);
            break;
             case ("/"):
             Console.WriteLine("----------------------------");
             Console.WriteLine(v1 / v2);
            break;
             case ("*"):
             Console.WriteLine("----------------------------");
             Console.WriteLine(v1 * v2);
                break;
             case ("%"):
             Console.WriteLine("----------------------------");
             Console.WriteLine(v1 % v2);
            break;
            }
            }

        }
    }
}
