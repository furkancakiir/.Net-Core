﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{


			// Operatörler


			// 1-ARİTMETİK OPERATÖRLER(+,-,*,/,%,++,--)

			int a = 10;
			int b = 20 ;

			float val;

			val = a + b; // 30
			val = a - b; // -10
			val = a * b; // 200
			val = (float)a / (float) b; // 0.5
			val = b % a; //0
			val = ++a; // ilk önce değeri arttırır val degiskeninin içine gönderir. a++ olsaydı atar sonra arttırma islemini yapılırdı.
			Console.WriteLine(val);
			Console.ReadLine();



			//2 Atama Operatörleri (=,+=,-=,*=,/=,%=(


			int x = 5, y = 10, z = 20;
			double val1;


			x += 5; // x = x + 5; // aynıdır
			x -= 5; // x = x - 5 // buda aynıdır
			x *= 5; // x= x * 5 dir
			x /= 5; // x = x / 5 dir.
			val1 = Math.Pow(x, y); // x taban y üssüdür. pow karesini alır .. 
			val1 = Math.Sqrt(25); // karakök alır . 
			val1 = Math.Abs(-10); // Gönderilen değere göre pozitifse negatif negatifse pozitif değerlerini gönderir. yani bir sayının mutlak değerini alır.
			val1 = Math.Round(4.4); // dikkat edilmesi gereken husus . kullanımıdır bir çok programcı , ile kullanmaya çalışmaktadır. round sayıyı yuvarlar örnegin 4.4  4e 4.6yısa 5e yuvarlar.5.5 olduğu zaman yukarıya yuvarlar
			val1 = Math.Ceiling(5.5); // Sayıyı yukarıya yuvarlar
			val1 = Math.Floor(5.5); // Sayıyı aşşağıya yuvarlar 
			Console.WriteLine($"x:{x} y:{y} z:{z}");
			Console.WriteLine(val1);
			Console.ReadLine();



			int ab = 2, ac = 5, az = 10; // int veri tipinide 3 adet degisken olusturduk.. 



			//Console.Write("1. Sayıyı Giriniz"+"Sayı Formatı 15 25 gibi olmalıdır . Ve , Kullanmayınız.");   // konsoldan kullanıcıdan vsayı girmesini icin write ile birlikte ekrana bastırıyoruz.ç
			//int sayi1 = int.Parse(Console.ReadLine()); // tabi sayi parse ederek kontrol isleminide gerceklestirmis oluyoruz 
			//Console.Write("2.Sayıyı Giriniz"); // kullanıcıdan tekrardan sayı girmesini bekliyoruz.
			//int sayi2 = int.Parse(Console.ReadLine());

			//int sonuc = (sayi1 * sayi2) - (ab + ac + az); // sonuc degiskenin icerisine sayi1 ile sayi 2 yi çarpıp yukarıda olusan sayıların farkını alıyoruz.

			//Console.Write("Sonuc" + sonuc);
			//Console.ReadLine();

			Console.Write("Sayı:");
			int sayi = int.Parse(Console.ReadLine());

			string sonuc = (sayi % 2) == 0 ? "Evet" : "Hayır"; // turner operatörler kullanarak bir koşul oluşturduk  // sayi çift 1 dönerse sayı tektir.

			Console.WriteLine($"Girilen sayı çiftmi {sonuc}");
			Console.ReadLine();


			// 3 Karsılastırma Operatörleri (==, !=,<,> <=,>=,?:)

			
			int aa = 5, bb = 5, cc = 10, dd = 4;
			string username = "furkancakir";
			string password = "1234567";

			var result = (a == b); // true
			result = (aa == cc); // false
			result = (username == "frknckr");
			result = (password == "123456");
			result = (aa != bb);
			result = (aa != cc);
			result = (aa > cc);
			result = (cc > aa);
			result = (aa >= bb);
			result = (aa <= bb);

			string sonuc2 = (a == b) ? "a=b" : "a!=b";
			sonuc = (username == "furkancakir") ?
		    (password == "123456") ? "username doğru ve parola doğru" : "username doğru ve parola yanlış" :
			(password == "123456") ? "username yanlış ve parola doğru" : "username yanlış ve parola yanlış";


			Console.WriteLine(sonuc);
			Console.WriteLine("result: " + result);




			// 4 Mantısal Operatörler (&& , || ,!)
			int f = 6;

			int hak = 0;
			char devammi = 'e';
			// and (&&)
			// true && true => true
			// false && true => false
			// false || false => false

			var results = (f > 5) && (f < 10);
			result = (hak > 0) && (devammi == 'e');

			// or (||)
			// true || true => true
			// false || true => true
			// false || false => false

			results = (f > 0) || (f % 2 == 0);

			// not (!)
			// true => false
			// false => true

			results = !(f > 0);

			// x, 5-10 arasında olan bir çift sayı mıdır?
			results = ((f > 5) && (f < 10)) && (f % 2 == 0); // (true && true) && true

			Console.Write(results);



			// 5-) Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ortalama hesaplayınız.
			//     Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
			// a-) Ortamalama 50 olsa bile final notu en az 50 olmalıdır.
			// b-) Finalden 70 alındığında ortalamanın önemi olmasın.


			// 6- Kişinin ad, kilo ve boy bilgilerini alıp kilo indekslerini hesaplayınız.
			// Formül: (Kilo / boy uzunluğunun karesi)
			// Aşağıdaki tabloya göre kişi hangi gruba girmektedir.
			// 0-18.4    => Zayıf 
			// 18.5-24.9 => Normal  
			// 25.0-29.9 => Fazla Kilolu
			// 30.0-34.9 => Şişman (Obez)


















		}
	}
}

