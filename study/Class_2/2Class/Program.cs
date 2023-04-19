using System;

namespace ConsoleApp1
{
	class Program
	{
		class Test
		{
			private int	n;
			
			public int	num
			{
				get
				{
					if (num > 100)
					{
						Console.WriteLine("you can get number over 100");
						num = 100;
					}
					else if(num < -100)
					{
						Console.WriteLine("you can get number under -100");
						num = -100;
					}
						n = num;
					return n;
				}
				set
				{
					n = value;
				}
			}
			public Test(int a)
			{
				n = a;
			}
			public void Show()
			{
				Console.WriteLine("n = {0}",n);
			}
		}
		static void Main(string[] args)
		{
			int	input;
			string order;
			while(true)
			{
				Console.WriteLine("Please enter number 'n'\nif you want quit program, type 'break'");
				order = Console.ReadLine();
				if (order == "break")
					return;
				input = int.Parse(order);
				Test testA = new Test(input);
				testA.Show();
				Console.WriteLine("Please enter number 'num'");
				testA.num = int.Parse(Console.ReadLine());
				testA.Show();
				Console.WriteLine();
			}
		}
	}
}

