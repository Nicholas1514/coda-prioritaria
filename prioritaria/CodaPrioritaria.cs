using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prioritaria
{
	/*
	Inserimento di un elemento (mantenendo l'ordinamento)
	Ricerca di un elemento
	Lettura del primo elemento(Peek)
	Estrazione del primo elemento
	Estrazione dell'ultimo elemento
	IsEmpty()
	*/
	public class CodaPrioritaria : IComparable
	{
		private ArrayList _ar;
		public ArrayList Ar
		{
			get { return _ar; }
			set { _ar = value; }
		}

		public CodaPrioritaria()
		{
			Ar = new ArrayList();
		}
		public CodaPrioritaria(ArrayList ar)
		{
			Ar = ar;
		}

		public CodaPrioritaria(CodaPrioritaria cp)
		{
			Ar = cp.Ar;
		}

		public void Aggiunta(object value)
		{
			Ar.Add(value);
		}

		public int Ricerca(object value)
		{
			return Ar.IndexOf(value);
		}

		public object Peek()
		{
			if (IsEmpty())
			{
				return null;
			} 
			
			return Ar[0];
		}

		public bool IsEmpty()
		{
			return Ar.Count == 0;
		}

		public object EstraiUltimo()
		{
			if (IsEmpty())
			{
				return null;
			}
			int ind = Ar.Count - 1;
			object value = Ar[ind];
			Ar.RemoveAt(ind);
			return value;
		}

		public object EstraiPrimo()
		{
			if (IsEmpty())
			{
				return null;
			}
			
			object value = Ar[0];
			Ar.RemoveAt(0);
			return value;
		}

		public override bool Equals(object obj)
		{
			if(!(obj is CodaPrioritaria) || obj == null)
			{
				return false;
			}
			CodaPrioritaria altro = (CodaPrioritaria)obj;
			return Ar.Equals(altro.Ar);
		}

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	}
}
