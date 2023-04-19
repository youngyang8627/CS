using System;

namespace Datatype2
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			Console.WriteLine("int 형 Max : {0} ~ Min : {1} size : {2}byte", int.MaxValue, int.MinValue, sizeof(int));
            Console.WriteLine(a);
 
            uint b = 10;
            Console.WriteLine("uint 형 Max : {0} ~ Min : {1} size : {2}byte", uint.MaxValue, uint.MinValue, sizeof(uint));
 
            short c = 10;
            Console.WriteLine("short 형 Max : {0} ~ Min : {1} size : {2}byte", short.MaxValue, short.MinValue, sizeof(short));
 
            ushort d = 10;
            Console.WriteLine("ushort 형 Max : {0} ~ Min : {1} size : {2}byte", ushort.MaxValue, ushort.MinValue, sizeof(ushort));
 
            long e = 10;
            Console.WriteLine("long 형 Max : {0} ~ Min : {1} size : {2}byte", long.MaxValue, long.MinValue, sizeof(long));
 
            ulong f = 10;
            Console.WriteLine("ulong 형 Max : {0} ~ Min : {1} size : {2}byte", ulong.MaxValue, ulong.MinValue, sizeof(ulong));
 
            byte g = 10;
            Console.WriteLine("byte 형 Max : {0} ~ Min : {1} size : {2}byte", byte.MaxValue, byte.MinValue, sizeof(byte));
 
            sbyte h = 10;
            Console.WriteLine("sbyte 형 Max : {0} ~ Min : {1} size : {2}byte", sbyte.MaxValue, sbyte.MinValue, sizeof(sbyte));
 
            char i = 'A';
            Console.WriteLine("char 형 size : {0}byte", sizeof(char));
 
            float j = 1.41421356237f;
            Console.WriteLine("float 형 Max : {0} ~ Min : {1} size : {2}byte", float.MaxValue, float.MinValue, sizeof(float));
            Console.WriteLine("{0}", j);
 
            double k = 1.41421356237d;
            Console.WriteLine("double 형 Max : {0} ~ Min : {1} size : {2}byte", double.MaxValue, double.MinValue, sizeof(double));
            Console.WriteLine("{0}", k);
 
            decimal l = 10m;
            Console.WriteLine("decimal 형 Max : {0} ~ Min : {1} size : {2}byte", decimal.MaxValue, decimal.MinValue, sizeof(decimal));
 
            bool m = false;
            Console.WriteLine("bool 형 size : {0}byte", sizeof(bool));
 
            object obj = null;
            string str = "";
        }
    }
}
