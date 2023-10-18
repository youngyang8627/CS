using System;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			string[]	String;
			string		Pop = "pop";
			int			i;
			int			Cnt = 0;
			int[]		Array;
			int			HowManyCmd;
			
			HowManyCmd = int.Parse(Console.ReadLine());
			Array = new int[Cnt];
			for(i = 0;i < HowManyCmd; i++)
			{
				String = Console.ReadLine().Split();
				if (Cnt < 0 && String.Equals(Pop) )
				{
					Console.WriteLine("Error. Program has down");
					return;
				}
				switch (String[0])
				{
					case "push" :
					{
						Array[Cnt] = int.Parse(String[1]);
						Cnt++;
						break;
					}
					case "pop" :
					{
						Cnt--;
						Console.WriteLine("{0}",Array[Cnt]);
						Array[Cnt] = 0;
						break;
					}
					case "size" :
					{
						Console.WriteLine("{0}",Cnt);
						break;
					}
					case "empty" :
					{
						if (Cnt == 0)
							Console.WriteLine("1");
						else
							Console.WriteLine("0");
						break;
					}
					case "top" :
					{
						Console.WriteLine("{0}",Array[Cnt - 1]);
						break;
					}
					default :
					{
						Console.WriteLine("Error. Please try again");
						break;
					}
				}
			}
		}
	}
}

