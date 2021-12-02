using System;
using System.Collections.Generic;

namespace Monitoria

{
    class Program
    {
        List<Posto> posto = new List<Posto>(); 
        static void Main(string[] args)
        {
            
            Posto abastecer = new Posto();
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("Escolha o Combustivel: [1 - Gasolina], [2 - Alcool], [3 - Diesel]");
                Console.WriteLine("-----------------------------------------------------------------");
                int com = int.Parse(Console.ReadLine());
                if (com > 3)
                {
                    break;
                }
                Console.WriteLine("Quantos litros vai abastecer :");
                float litros = float.Parse(Console.ReadLine());
                abastecer.setCombustivel(com, litros);


            }
         }
    }
}
