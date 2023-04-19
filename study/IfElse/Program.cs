using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int	a;
			int	b;

			a = 10;
			b = 20;
			if (a > b)
				Console.WriteLine("a is bigger than b");
			else
				Console.WriteLine("b is bigger than a");

			if (a == b)
			{
				Console.WriteLine("a and b has same value");
			}
			else if (a < b)
			{
				Console.WriteLine("a is smaller than b");
			}
			else
			{
				Console.WriteLine("b is smaller than a");
			}
		}
	}
}
