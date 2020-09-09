using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Bir Sayı Giriniz:");
			//int sayi1 =int.Parse(Console.ReadLine());
			//Console.Write("İkinci Sayıyı Giriniz:");
			//int sayi2 = int.Parse(Console.ReadLine());

			//if (sayi1 > sayi2)
			//{
			//	Console.WriteLine($"{sayi1}.sayi 2. sayidan büyüktür");
			//	Console.ReadLine();
			//}
			//else if (sayi1 < sayi2)
			//{
			//	Console.WriteLine($"{sayi2} sayısı sayi1 den daha büyüktür");
			//	Console.ReadLine();
			//}
			//else if(sayi1==sayi2)
			//{
			//	Console.WriteLine($"sayilar eşittir");
			//	Console.ReadLine();

			//}

			//string _email = "cakirbeylii28@gmail.com";
			//string _password = "12345";

			//Console.Write("email");
			//string email = Console.ReadLine();

			//Console.Write("Password");
			//string password = Console.ReadLine();

			//var result = (_email == email) && (_password == password);

			//Console.WriteLine("Giriş Başarılı" + result);

			//Console.Write("Sayi:");
			//int sayi = int.Parse(Console.ReadLine());

			//var result = (sayi > 0) && (sayi % 2 == 0);
			//Console.WriteLine("Sayı Pozitif Çift Sayıdır" + result);

			//Console.Write("Bir Sayı Giriniz");
			//int sayi1 = int.Parse(Console.ReadLine());

			//Console.Write("Bir Sayı Giriniz");
			//int sayi2 = int.Parse(Console.ReadLine());

			//Console.Write("Bir Sayı Giriniz");
			//int sayi3 = int.Parse(Console.ReadLine());

			//var result = (sayi1 > sayi2) && (sayi1 > sayi3);
			//Console.WriteLine("En büyük sayı :" + result);


			// result = (sayi2 > sayi1) && (sayi2 > sayi3);
			//Console.WriteLine("En büyük sayi:" + result);


			//result = (sayi3 > sayi1) && (sayi3 > sayi2);
			//Console.WriteLine("En büyük sayi:" + result);
			//Console.ReadLine();

			//Console.Write("Vize Notunuz:");
			//int vize = int.Parse(Console.ReadLine());

			//Console.Write("Final Notunuz:");
			//int final = int.Parse(Console.ReadLine());

			//var result = ((vize + final) / 2) * 0.6 + (final * 0.4);

			//Console.WriteLine("Ortalama " + result);
			//Console.WriteLine(result >= 50 ? "geçti" : "kaldı");
			//Console.ReadLine();


			Console.Write("Adınız:");
			string ad = Console.ReadLine();

			Console.Write("Kilonuz:");
			float kilo = float.Parse(Console.ReadLine());

			Console.Write("Boy:");
			float boy = float.Parse(Console.ReadLine());

			float indeks = kilo / boy * boy;


			var zayif = (indeks >= 0) && (indeks <= 18.4);

			var normal = (indeks > 18.4) && (indeks <= 24.9);

			var kilolu = (indeks > 24.9) && (indeks <= 29.9);

			var obez = (indeks > 29.9) && (indeks <= 34.9);



			Console.WriteLine($"{ad} kilo indeksin {indeks} ve kilo değerlendirmen zayıf:{zayif}");
			Console.WriteLine($"{ad} kilo indeksin {indeks} ve kilo değerlendirmen normal:{normal}");
			Console.WriteLine($"{ad} kilo indeksin {indeks} ve kilo değerlendirmen kilolu:{kilolu}");
			Console.WriteLine($"{ad} kilo indeksin {indeks} ve kilo değerlendirmen obez:{obez}");

			Console.ReadLine();

		}
	}
}
