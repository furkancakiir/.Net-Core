﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Parametreleri
{
	class Islem
	{
		// public int Toplama(int x, int y=0, int z=0)
		// {
		//     Console.WriteLine("x " + x);
		//     Console.WriteLine("y " + y);
		//     Console.WriteLine("z " + z);

		//     return x + y + z;
		// }

		public int Toplama(params int[] sayilar)
		{
			int toplam = 0;
			foreach (var sayi in sayilar)
			{
				toplam += sayi;
			}
			return toplam;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var islem = new Islem();

			// Console.WriteLine(islem.Toplama(10, 20, 30));
			// Console.WriteLine(islem.Toplama(y: 20, z: 30, x: 10)); // Named 
			// Console.WriteLine(islem.Toplama(10,20)); // default 
			Console.WriteLine(islem.Toplama(10));
			Console.WriteLine(islem.Toplama(10, 20));
			Console.WriteLine(islem.Toplama(10, 20, 30));
			Console.WriteLine(islem.Toplama(10, 20, 30, 40));
		}
	}
}
