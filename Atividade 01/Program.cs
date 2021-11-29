using System;

namespace Aula_01
{
    class Program{
        public static void Main(string[] args){ 
         
         int v1, v2, v3;
        Console.WriteLine("Digite o valor 01");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor 02");
        v2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor 03");
        v3 = int.Parse(Console.ReadLine());
        if(v1 > v2 & v1 < v3) {
            Console.WriteLine("Numero do meio é"+v1);
        }else if(v2 > v1 & v2 < v3){
            Console.WriteLine("Numero do meio é"+v2);
        }else if(v3 > v1 & v3 < v2){
            Console.WriteLine("Numero do meio é"+v3);
        }else if(v1 < v2 & v1 > v3){
            Console.WriteLine("Numero do meio é"+v1);
        }else if(v2 < v1 & v2 > v3){
            Console.WriteLine("Numero do meio é"+v2);
        }else if(v3 > v1 & v3 < v2){
            Console.WriteLine("Numero do meio é"+v3);
        }else {
            Console.WriteLine("Numero iguais!");
        }

        
        


           



        }
    }
}
