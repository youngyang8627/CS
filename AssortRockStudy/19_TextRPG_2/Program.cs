using System;

// 초반 프로그래밍 전부
// 객체(클래스) 를 선언해야 할 때
// 함수의 분기
// 함수를 합칠때와 쪼갤때.
// 함수는 비대하지 않을 때 좋다
enum STARTSELECT
{
	SELECTTOWN,
	SELECTBATTLE,
	SELECTSTART,
	SELECTSHUTDOWN,
	NONE
}
class Monster
{
	int Hp = 100;
	int At = 7;
	int Df = 2;
	int Max_HP = 100;
	public void Recovery_HP()
	{
		this.Hp = this.Max_HP;
	}
	public void Attack(Player _Ply)
	{
		_Ply.Damaged(this.At);
	}
	public void Damaged(int _Dmg)
	{
		this.Hp -= (_Dmg - Df);
	}
}

class Player
{
	string Pname;
	int Hp = 50;
	int At = 10;
	int Df = 3;
	int Max_HP = 100;
	int Magic = 20;
	
	public void GetName(/*Player this*/)
	{
		Console.WriteLine("Please Type your name");
		Pname = Console.ReadLine();
	}
	public void StatusRender()
	{
		Console.Clear();
		Console.WriteLine(Pname + "'s Status");
		Console.WriteLine("-------------------------------------------------------------------------------");
		Console.Write("Attack = ");
		Console.WriteLine(At);
		Console.Write("HP = ");
		Console.Write(Hp);
		Console.Write(" / ");
		Console.WriteLine(Max_HP);
		Console.WriteLine("-------------------------------------------------------------------------------");
	}
	public void Recovery_HP(int _Heal)
	{
		if (this.Hp == this.Max_HP)
		{
			Console.WriteLine("The HP is full " + this.Hp + " / " + this.Max_HP);
			Console.WriteLine("- Press any key for continue -");
			Console.ReadKey();
			return;
		}
		else if (this.Hp > this.Max_HP)
		{
			Console.WriteLine("The Hp is overwhelming!" + this.Hp + " / " + this.Max_HP);
			Console.WriteLine("- Press any key for continue -");
			Console.ReadKey();
			return;
		}
		this.Hp += _Heal;
		if (this.Hp > this.Max_HP || Hp < 0)
		{
			Console.WriteLine((this.Max_HP - this.Hp) + " has recoveried!");
			this.Hp = this.Max_HP;
		}
		else
			Console.WriteLine(_Heal + " has recoveried!");
		Console.WriteLine("Your HP is now " + Hp + "/"  + Max_HP);
		Console.WriteLine("- Press any key for continue -");
		Console.ReadKey();
	}
	public void Attack(Monster _Mon)
	{
		_Mon.Damaged(At);
	}
	public void Enhanced()
	{
		this.At += 2;
		Console.WriteLine("Your attack has increased to " + At);
		Console.WriteLine("- Press any key for continue -");
		Console.ReadKey();
	}
	public void Damaged(int _Dmg)
	{
		this.Hp -= (_Dmg - this.Df);
	}
	public void HealAnother(Player _Other)
	{
		_Other.Recovery_HP(Magic);
	}
}

namespace _19_TextRpgPlusAlpha
{
	class Test
	{
		public int Number()
		{
			return 0;
		}
	}
	class Program
	{
		static STARTSELECT StartSelect(Player _Ply)
		{
			_Ply.StatusRender();
			Console.WriteLine("Please push the key for select Location");
			Console.WriteLine("1. Town\n2. Fighter's Club\n3. Startzone\n4. Shutdown Program");
			ConsoleKeyInfo Select = Console.ReadKey();
			Console.Clear();
			switch(Select.Key)
			{
				case ConsoleKey.D1 :
					return (STARTSELECT.SELECTTOWN);
				case ConsoleKey.D2 :
					return (STARTSELECT.SELECTBATTLE);
				case ConsoleKey.D3 :
					return (STARTSELECT.SELECTSTART);
				case ConsoleKey.D4 :
					Console.WriteLine("Are you sure?\nY / N");
					Select = Console.ReadKey();
					Console.Clear();
					if (Select.Key == ConsoleKey.Y)
						return (STARTSELECT.SELECTSHUTDOWN);
					else
						Console.Clear();
						return (StartSelect(_Ply));
				default :
					return (STARTSELECT.NONE);
			}
			return (STARTSELECT.NONE);
		}
		static void Town(Player _TownPlayer)
		{
			while(true)
			{
				Console.Clear();
				_TownPlayer.StatusRender();
				Console.WriteLine("What will you do in town?");
				Console.WriteLine("1. Recovery all your HP\n2. Recovery 10 HP\n3. Weapon enhancement\n4. Live town");
				switch (Console.ReadKey().Key)
				{
					case ConsoleKey.D1 :
						Console.Clear();
						_TownPlayer.Recovery_HP(100000);
						break;
					case ConsoleKey.D2 :
						Console.Clear();
						_TownPlayer.Recovery_HP(10);
						break;
					case ConsoleKey.D3 :
						Console.Clear();
						_TownPlayer.Enhanced();
						break;
					case ConsoleKey.D4 :
						return;
					default :
						Console.Clear();
						Console.WriteLine("ERROR : There are no choice");
						Console.WriteLine("- Press any key for continue -");
						Console.ReadKey();
						break;
				}
			}

		}
		static void Battle(Player _BattlePlayer)
		{
			Console.WriteLine("Hello, this is Fighters Club.\nWe are not open yet.");
			Console.WriteLine("- Press any key for continue -");
			Console.ReadKey();
		}
		static void Main(string[] args)
		{
			STARTSELECT Select;
			Player NewPlayer = new Player();
			NewPlayer.GetName();
			Console.Clear();
			while(true)
			{
				Select = StartSelect(NewPlayer);
				switch (Select)
				{
					case STARTSELECT.SELECTTOWN :
						Console.WriteLine("We're heading to the Town...");
						Console.WriteLine("- Press any key for continue -");
						Console.ReadKey();
						Console.Clear();
						Town(NewPlayer);
						break;
					case STARTSELECT.SELECTBATTLE :
						Console.WriteLine("We're heading to the Fighters club...");
						Console.WriteLine("- Press any key for continue -");
						Console.ReadKey();
						Console.Clear();
						Battle(NewPlayer);
						break;
					case STARTSELECT.SELECTSTART :
						Console.WriteLine("We're already on Startzone");
						Console.WriteLine("- Press any key for continue -");
						Console.ReadKey();
						break;
					case STARTSELECT.SELECTSHUTDOWN :
						Console.WriteLine("Shutdown Program...");
						Console.Write("- Press any key for continue -");
						Console.ReadKey();
						return;
					default :
						Console.WriteLine("ERROR : There are not have location");
						Console.WriteLine("- Press any key for continue -");
						Console.ReadKey();
						break;
				}
			}
		}
	}
}

			

