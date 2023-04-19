using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string	str;
			string	spc;
			char 	ch;
			int		cnt;
			int		tmp;

			str = Console.ReadLine().Trim();
			spc = " ";
			tmp = String.Compare(str, spc, true);
			//ㄴ Trim 사용 이유는 앞뒤 공백 제거하려고
			ch = ' ';
			cnt = str.Split(ch).Length;
			if (tmp == 0)
				cnt--;
			Console.WriteLine(cnt);
		}
	}
}

