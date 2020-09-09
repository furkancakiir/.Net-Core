using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşul
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Kullanıcı Adınızı Giriniz");
			string userName = "Furkan";

			Console.ReadLine();

			Console.Write("Password Giriniz Lütfen");
			string password = "12345";

			Console.ReadLine();


			if (userName == "Furkan")
			{

				if (password == "12345")
				{
					Console.WriteLine("Bilgileriniz doğru ");
					Console.WriteLine($"Hoşgeldiniz {userName}");
					Console.ReadLine();
				}

				else
				{
					Console.WriteLine("Parola Yanlış");
				}
			}
			else
			{
				Console.WriteLine("Kullanıcı Adı Yanlış");
			}




			}

		}
	}

