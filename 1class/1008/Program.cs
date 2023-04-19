using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			double		a;
			double		b;
			double		div;
			string[]	strs;

			strs = Console.ReadLine().Split();
			a = double.Parse(strs[0]);
			b = double.Parse(strs[1]);
			div = a / b;
			Console.WriteLine("{0}", div);
		}
	}
}
