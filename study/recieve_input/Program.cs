using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string	a;
			string	str;
			int		b;

			Console.WriteLine("Please type string a");
			a = Console.ReadLine();
			Console.WriteLine("Please type int b");
			str = Console.ReadLine();
			b = Convert.ToInt32(str);
			Console.WriteLine("a : {0}, b : {1}", a, b);
		}
	}
}
