using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Fırlatma
{

	class Personel
	{

		string _name;

		public string Name
		{
			get {
				return _name;
			}
			set
			{
				if (value.Length < 15)
					throw new Exception("Name için en fazla 15 karakter girmelisiniz");
				_name = value;
			}



		}


		class Program
		{
			static void Main(string[] args)
			{

				//string parola = "12345a";

				//try
				//{
				//	check_password(parola);
				//	Console.WriteLine("Parola geçerlidir");
				//}
				//catch (Exception ex)
				//{
				//	Console.WriteLine(ex.Message);
				//}


				try
				{

					var p = new Personel();
					{
						p.Name = "Furkan";
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.ReadLine();
				}
				Console.ReadLine();





		}

			static void check_password(string password)
			{
				if (password.Length < 8 || password.Length > 15)
					throw new Exception("Paralo 7-15 Karakter arasıdna olmalıdır");
				if (!password.Any(char.IsDigit))
					throw new Exception("Parola en az bir rakam içermelidir");
				if (!password.Any(char.IsLetter))
					throw new Exception("Parola en az bir harf içermelidir");

				Console.ReadLine();
			}

		}
	}
}
