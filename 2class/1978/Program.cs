using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int			a;
			int			i;
			int			j;
			int			cnt;
			int			check;
			int[]		prime;
			string		str;
			string[]	strs;

			str = Console.ReadLine();
			prime = new int[101];
			a = int.Parse(str);
			strs = Console.ReadLine().Split();
			for (i = 0; i < a; i ++)
			{
				prime[i] = int.Parse(strs[i]);
			}
			cnt = 0;
			for (i = 0; i < a; i++)
			{
				check = 0;
				for (j = 2; j < 1001; j++)
				{
					if (prime[i] / j != 0)
					{
						check = 1;
						break;
					}
				}
				if (check == 0)
					cnt++;
			}
			Console.WriteLine("{0}",cnt);
		}
	}
}
