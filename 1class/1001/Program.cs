using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] str;

			str = Console.ReadLine().Split();
			Console.WriteLine("{0}", int.Parse(str[0]) - int.Parse(str[1]));
		}
	}
}
