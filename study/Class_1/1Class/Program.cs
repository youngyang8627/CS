using System;

namespace	ConsoleApp1
{
	class	Hero
	{
		public string	sName;
		public int		nHp;
		public int		nPower;
		
		public void Attack(string target)
		{
			Console.WriteLine("{0} has taken {1} damage", target, nPower);
			// ㄴ {0}에게 {1}의 데미지를 주었습니다.
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Hero newHero = new Hero();
			newHero.sName = "Max";
			newHero.nHp = 10;
			newHero.nPower = 2;
	
			Console.WriteLine(" name : {0}, hp : {1}, power : {2}", newHero.sName, newHero.nHp, newHero.nPower);
			newHero.Attack("scarecrow");
		}
	}
}

