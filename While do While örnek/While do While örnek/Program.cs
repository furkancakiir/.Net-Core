﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_do_While_örnek
{
	class Program
	{
		static void Main(string[] args)
		{
			//int i = 0;

			//Console.Write("Bir Sayı giriniz:");
			//int sayi = int.Parse(Console.ReadLine());

			//while (i<=sayi)
			//{

			//	if (i % 2 == 0)
			//		Console.WriteLine(i + ":Cift");
			//	else
			//		Console.WriteLine(i + ":Tek");

			//	i++;
			//}
			//Console.ReadLine();



			//string name = "";
			//while (string.IsNullOrEmpty(name))
			//{
			//	Console.Write(":İsminiz:");
			//	name = Console.ReadLine();
			//}
			//Console.WriteLine($"Merhaba {name}");
			//Console.ReadLine();

			string name = "";
			do
			{
				Console.Write(":İsminiz:");
				name = Console.ReadLine();

			} while (string.IsNullOrEmpty(name));

		}
	}
}
