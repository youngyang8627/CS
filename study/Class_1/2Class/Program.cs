using System;

namespace ConsoleApp1
{
	class TestClass
	{
		private string sName;
		public TestClass(string name)
		{
			sName = name;
			Console.WriteLine(sName + " Produced!");
		}
		~TestClass()
		{
			Console.WriteLine(sName + " extinction!");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			TestClass testA = new TestClass("A object");
			TestClass testB = new TestClass("B object");
			TestClass testC = new TestClass("C object");
		}
	}
}


