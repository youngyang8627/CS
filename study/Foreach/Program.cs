using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int		n;
			int[]	arr = {1, 3, 5, 7, 9, 2, 4, 6, 8};;

			n = 0;
		
			foreach(int i in arr)
			{
				Console.WriteLine("n[{0}] = {1}", n , i);
				n++;
			}
		}
	}
}

