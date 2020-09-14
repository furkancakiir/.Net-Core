using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendi_Hata_Sınıfımız
{

	class LoginException:Exception
	{
		public LoginException(string message):base(message)
		{
			
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{

			try
			{
				Login("FURKANÇAKIR", "12345678");
				Console.WriteLine("Login işlemi başarılıdır");
				Console.ReadLine();
			}
			catch (LoginException ex)
			{

				Console.WriteLine(ex.Message);
			
				
			}

		}


		static void Login(string username,string password)
		{
			if(username.Contains(" "))
			
				throw new LoginException("Username boşluk içeremez");

			if (password.Length < 8)

				throw new Exception("Parola min 8 Karakter Olmalıdır");



			Console.ReadLine();
		}
		

	}
}
