using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int	n;

			n = 5;
			do
			{
				Console.WriteLine("n : {0}", n--);
			}
			while (n > 0);
		}
	}
}
