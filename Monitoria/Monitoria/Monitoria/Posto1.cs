using System;
using System.Collections.Generic;
namespace Monitoria
{
    internal class Posto
    {
		const float gasolina = 4.5f;
		const float alcool = 3.5f;
		const float diesel = 5.00f;
		public void setCombustivel(int com, float litros)
		{
				switch (com)
				{
					case (1):
						Console.WriteLine("Gasolina valor : R$" + (gasolina * litros));

						break;
					case (2):
						Console.WriteLine("Alcool valor : R$" + alcool * litros);
						break;
					case (3):
						Console.WriteLine("Diesel valor : R$" + diesel * litros);
						break;
					default:
						Console.WriteLine("Escolha um combustivel valido");
						break;
				}
			
		}
}
}