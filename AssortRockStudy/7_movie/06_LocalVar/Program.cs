using System

// C# is classic OOP(Object Oriented Programming) Language;
// Only C# know classes;
// When you start Program;
// You should make class and put in;


class Player()
{
	// Member Parameter is in the Class.
	int Att;
	int Hp;
	void Fight()
	{
		Console.WriteLine("Player fight");
	}
}


namespace _06LocalVar
{
	class Program
	{
		//Function for start;
		static void Main(string[] args)
		{
			//Local Parameter's Law
			// 1. Only use for this Function;
			// 2. If you declaration than store memory immediately
			//
			Player NewPlayer_2 = new Player(); // You can make several Object to use same class;
			Player NewPlayer_2 = new Player(); // <= This is the code for make Player object named NewPlayer_2;
			int ATT = 0; // <= this ls Local Parameter
			ATT = 50;
			Console.WriteLine("Hello World!!");
		}
		//Class is BluePrint. If you want to use, than You should make Object;

	}
}
