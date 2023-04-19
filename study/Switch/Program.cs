using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int	a;
		
			a = 13;
			switch (a)
			{
				case 10 :
					{
						Console.WriteLine("a is ten");
						break;
					}
				case 13 :
					{
						Console.WriteLine("a is thirteen");
						break;
					}
				default :
					{
						Console.WriteLine("nothing");
						break;
					}
			}
			Console.WriteLine();

			string str;
		
			str = "파랑";
			switch (str)
			{
				case "빨강" :
					{
						Console.WriteLine("which color you like {0}", str);
						break;
					}
				case "노랑" :
					{
						Console.WriteLine("which color you like {0}", str);
						break;
					}
				case "파랑" :
					{
						Console.WriteLine("which color you like {0}", str);
						break;
					}
				default :
					{
						Console.WriteLine("you don't have favorite color");
						break;
					}
			}
		}
	}
}

