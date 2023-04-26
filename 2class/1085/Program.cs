using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[]	str;
			int			a;
			int			b;
			int			x;
			int			y;
			int			ansx;
			int			ansy;

			str = Console.ReadLine().Split();
			a = int.Parse(str[0]);
			b = int.Parse(str[1]);
			x = int.Parse(str[2]);
			y = int.Parse(str[3]);
			if (a > x / 2)
				ansx = x - a;
			else
				ansx = a;
			if (b > y / 2)
				ansy = y - b;
			else
				ansy = b;
			if (ansx < ansy)
				Console.WriteLine("{0}", ansx);
			else
				Console.WriteLine("{0}", ansy);
		}
	}
}
