using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_Break_Continue
{
	class Program
	{
		static void Main(string[] args)
		{

			bool asalMi = true;

			Console.Write("Sayi giriniz:");
			int sayi = int.Parse(Console.ReadLine());

			if (sayi == 1)
				Console.WriteLine("1 Asal Sayı Değildir");

			for (int i = 2; i <sayi; i++)
			{
				if (sayi % i == 0)
				{
					asalMi = false;
					break;
				}
			}

			if (asalMi)
				Console.Write("sayi asaldır");
			else
				Console.WriteLine("Sayı asal değildir");
			Console.ReadLine();

		}
	}
}
