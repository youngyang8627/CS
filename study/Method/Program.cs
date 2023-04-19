using System;

namespace ConsoleApp1
{
	class Program
	{
		static int intPlus(int a, int b)
		{
			int	result = a + b;
			return result;
		}
		static void Main(string[] args)
		{
			int nPlus = intPlus(10, 20);
			Console.WriteLine(nPlus);
		}
	}
}
