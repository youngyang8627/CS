using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string number;
			int num;
			number = Console.ReadLine();
			num = int.Parse(number);
			for (int i = 1; i <= num; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
