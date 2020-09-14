using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{

			try
			{
				Console.Write("1.Sayı");
				int sayi = int.Parse(Console.ReadLine());

				Console.Write("2.Sayı");
				int sayi1 = int.Parse(Console.ReadLine());


				var sonuc = sayi / sayi1;

				Console.WriteLine($"{0}/{1}={2}", sayi, sayi1, sonuc);
			}
			catch (DivideByZeroException ex)
			{

				Console.WriteLine("B 0 OLAMAZ");
				Console.WriteLine(ex.Message);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Sayısal bir bilgi girmelisiniz");
				Console.WriteLine(ex.HelpLink);

			}
			catch (Exception ex)
			{
				Console.WriteLine("Bir Hata Oluştdu");
				Console.WriteLine(ex.Message);
			}

			finally
			{
				Console.WriteLine("Finaly Çalıştı"); // Try catch  hata yakalamak için kullanılır finally bölümünde hata olsun yada olmasın kod blogu calısmaya devam edicektir.
			}


			Console.ReadLine();

		}
	}
}
