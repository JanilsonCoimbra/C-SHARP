using System;

namespace Atividade_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;

            for(int cont = 1; cont <= 20; cont++) {
                if(cont % 2 == 0) {
                    par++;
                }else if(cont % 2 == 1) {
                    impar++;
                }
            }
            Console.WriteLine("Total de numeros pares :"+par);
            Console.WriteLine("Total de numeros impares :"+impar);
            Console.WriteLine("Total de numeros :"+(impar + par));
        }
    }
}
