using System;
using System.Collections;
using System.Data;



namespace Atividade_06
{
    class Program
    {   

        static void Main(string[] args)
        {
            var date = new DateTime();
            var list = new ArrayList();
            list.Add(date.Add);
            Console.WriteLine(list[0]);

            foreach(var item in list)
            {
                Console.WriteLine(String.Format("Datas cadastradas {$}", item));
            }

        }
    }
}
