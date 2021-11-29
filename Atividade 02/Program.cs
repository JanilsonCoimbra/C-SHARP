using System;

namespace Aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, media;
            
            Console.WriteLine("Sua nota 01 :");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sua nota 02 :");
            n2 = float.Parse(Console.ReadLine());
            media = (n1 + n2)/2;
            Console.WriteLine("Sua media foi "+media+" e você foi " + (media>7?"Aprovado":"Reprovado"));

        }
    }
}
