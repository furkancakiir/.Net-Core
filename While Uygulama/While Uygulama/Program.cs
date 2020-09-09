using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Uygulama
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Adet sayisi giriniz");

			int adet = int.Parse(Console.ReadLine());

			string[] urunler = new string[adet];


			int i = 0;

			do
			{

				Console.Write($"{i+1}.Ürün Adı:");	
				urunler[i] = Console.ReadLine();
				i++;

			} while (adet!=i);


			Console.WriteLine("Ürünler Listeleniyor:");

			for (int j = 0; j <urunler.Length; j++)
			{
				Console.WriteLine($"{j+1}.ürün adı:{urunler[j]}");
			}
			Console.ReadLine();

		} 
	}
}
