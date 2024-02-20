using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prioritaria
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CodaPrioritaria cp = new CodaPrioritaria();
			int scelta = 0;
			do
			{
				Console.Clear();
				Console.WriteLine("1 - Inserisci elemento");
				Console.WriteLine("2 - Ricerca elemento");
				Console.WriteLine("3 - Lettura primo elemento");
				Console.WriteLine("4 - Estrazione primo elemento");
				Console.WriteLine("5 - Estrazione ultimo elemento");
				Console.WriteLine("6 - Controllo se Ar è vuota");
				Console.WriteLine("7 - Visualizza");
				Console.WriteLine("0 - Esci");
				Console.WriteLine("Inserisci la scelta:");
				scelta = int.Parse(Console.ReadLine());

				switch (scelta)
				{
					case 0:
						break;
					case 1:
						Console.WriteLine("Inserisci elemento");
						object value = Console.ReadLine();
						cp.Aggiunta(value);
						cp.Ar.Sort();
						Console.WriteLine("Elemento aggiunto");
						break;
						case 2:
						Console.WriteLine("Inserisci elemento da ricercare");
						object cerca = Console.ReadLine();
						int ind = cp.Ricerca(cerca);
						Console.WriteLine($"Elemento trovato in posizione {ind}");
						break;
					case 3:
						object peek = cp.Peek();
						Console.WriteLine($"Peek: {peek}");
						break; 
					case 4:
						object primo = cp.EstraiPrimo();
						Console.WriteLine($"Primo: {primo}");
						cp.Ar.Sort();
						break;
						case 5:
						object ultimo = cp.EstraiUltimo();
						Console.WriteLine($"Primo: {ultimo}");
						cp.Ar.Sort();
						break;
						case 6:
						bool controllo = cp.IsEmpty();
						Console.WriteLine("La lista è vuota? " + controllo);
						break;
						case 7:
						cp.Ar.Sort();
						foreach (var item in cp.Ar)
						{
							Console.WriteLine(item);
						}
						break;
				}
				Console.ReadLine();
			} while (scelta != 0);

		}
	}
}
