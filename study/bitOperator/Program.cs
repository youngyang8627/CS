using System;

namespace BitOperator
{
	class Program
	{
		static void Main(string[] args)
		{
			// 비트 이항 연산자
			// &,  |, ^, <<, >>
			byte	a;
			byte	b;
			string	s;

			a = 15;
			b = 5;
			s = "";

			s = Convert.ToString(a, 2).PadLeft(8, '0');
			// ㄴ 8자리의 bit로 표현
			Console.WriteLine("a	  : {0}, Bit : {1} ", a, s);
			// ㄴ Console.WriteLine에 개행 있어서 개행문자 넣지 않음
			s = Convert.ToString(b, 2).PadLeft(8, '0');
			Console.WriteLine("b	  : {0}, Bit : {1} \n", b, s);

			s = Convert.ToString((a & b), 2).PadLeft(8, '0');
			Console.WriteLine("a & b  : {0}, Bit : {1}\n", a & b, s);
			
			s = Convert.ToString((a | b), 2).PadLeft(8, '0');
			Console.WriteLine("a | b  : {0}, Bit : {1}\n", a | b, s);
			
			s = Convert.ToString((a ^ b), 2).PadLeft(8, '0');
			Console.WriteLine("a ^ b  : {0}, Bit : {1}\n", a ^ b, s);

			s = Convert.ToString((a << 1), 2).PadLeft(8, '0');
			Console.WriteLine("a << 1 : {0}, Bit : {1}\n", a << 1, s);
			
			s = Convert.ToString((a << 2), 2).PadLeft(8, '0');
			Console.WriteLine("a << 2 : {0}, Bit : {1}\n", a << 2, s);

			s = Convert.ToString((a >> 1), 2).PadLeft(8, '0');
			Console.WriteLine("a >> 1 : {0}, Bit : {1}\n", a >> 1, s);

			s = Convert.ToString((a >> 2), 2).PadLeft(8, '0');
			Console.WriteLine("a >> 2 : {0}, Bit : {1}\n", a >> 2, s);
		}
	}
}

