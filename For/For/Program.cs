using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
	class Program
	{
		static void Main(string[] args)
		{

			int toplam = 0;
			for (int i = 0; i<100; i++)
			{
				if (i % 2 == 0)
				{
					toplam += i;
					Console.WriteLine(toplam);
				}
				
			}
			


			string[] isimler = { "Ahmet", "Mehmet", "Can", "Veli" };

			for (int i = 0; i < isimler.Length; i++)
			{
				Console.WriteLine(isimler[i]);
			}
			Console.ReadLine();


		}
	}
}
