using System;

namespace datatype1
{
	class Program
	{
		static void Main(string[] args)
		{
			int		a;
			float	b;
			double	c;
			byte	d;
			long	e;
			sbyte	f;
			bool	g;

			a = 10;
			b = (float)2342.3423;
			c = (double)4857392345.3452345342;
			d = 253;
			e = 42387582739324;
			f = -23;
			g = false;
			Console.WriteLine(a);
			Console.WriteLine("int형 Max : {0}\nMin : {1}\nsize {2}byte",int.MaxValue,int.MinValue,sizeof(int));
			Console.WriteLine("float형 b : {0}\ndouble type c : {1}\nbyte type d : {2}",b,c,d);
			Console.WriteLine("long long type e : {0}\nsbyte type f : {1}\nbool type g : {2}\n",e,f,g);
		}
	}
}

