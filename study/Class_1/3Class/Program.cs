using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int	a1;
			int	b1;
			int	c1;
			int	result1;
			int	result2;
		
			a1 = 3;
			b1 = 5;
			c1 = 8;
			result1 = Sum(a1, b1);
			result2 = Sum(a1, b1, c1);
			Console.WriteLine("a = {0}, b = {1}, c = {2}", a1, b1, c1);
			Console.WriteLine("result1 = a + b = {0} + {1} = {2}", a1, b1, result1);
			Console.WriteLine("result2 = a + b + c = {0} + {1} + {2} = {3}", a1, b1, c1, result2);
		}	
		static int Sum(int a, int b)
        {
           	return a + b;
       	}
       	static int Sum(int a, int b, int c)
       	{
       		return a + b + c;
       	}
	}
}
	
