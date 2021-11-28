using System;

namespace Aula_01
{
    class Program{
        public static void Main(string[] args){
            
            int numero;
            numero = Console.Read();
            if(numero % 2 == 0) {
                Console.WriteLine("PAR");
            }else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
