using System;
// 마을과 싸움터 질문지 출력 및 선택 가능하게
// 만들 때 우선 순위를 정하고 구현
/*
	마을
	마을에 도착했습니다.
	ㄴ 1. 여관에 들른다.
	ㄴ 2. 공격력을 강화한다.
	ㄴ 3. 나간다.

	싸움터
	싸움터에 도착했습니다.
	ㄴ 몬스터가 등장한다.
	ㄴ 1. 데미지를 입혔다.
		ㄴ xx는 y의 hp가 남았다.
	ㄴ 2. 도망간다...
*/
/*
class Monster
{

}

class Player
{
	int Hp = 100;
	int Att = 7;
	public void Set_Hp(int Tmp)
	{
		Hp = Tmp;
	}
	public void Set_Att(int Tmp)
	{
		Att = Tmp;
	}
	public void Add_Hp(int Tmp)
	{
		Hp += Tmp;
	}
	public void Add_Att(int Tmp)
	{
		Att += Tmp;
	}

}

class Town
{
	static void Inn(Player _Player)
	{

	}
}

class Fighters_Club
{

}
*/
enum STARTSELECT
{
	// enum 만들 시 예상치 못한 경우가 있기 때문에 none 등을 만들어 구분해둠.
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
		Hp = Max_HP;
	}
	public void Attack(Player _Ply)
	{
		_Ply.Damaged(At);
	}
	public void Damaged(int _Dmg)
	{
		Hp -= (_Dmg - Df);
	}

}

class Player
{
	string Pname;
	int Hp = 50;
	int At = 10;
	int Df = 3;
	int Max_HP = 100;
	
	public void GetName()
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
	public void Recovery_HP()
	{
		Hp = Max_HP;
		Console.WriteLine("HP Recorveried!\nYour HP is now " + Hp + "/"  + Max_HP);
		Console.WriteLine("- Press any key -");
		Console.ReadKey();
	}
	public void Attack(Monster _Mon)
	{
		_Mon.Damaged(At);
	}
	public void Enhanced()
	{
		At += 2;
		Console.WriteLine("Your attack has increased to " + At);
		Console.WriteLine("- Press any key -");
		Console.ReadKey();
	}
	public void Damaged(int _Dmg)
	{
		Hp -= (_Dmg - Df);
	}
}

//클래스는 왠만하면 자신의 멤버변수는 제공하지 않되, 멤버함수와 인터페이스 만으로 처리하는게 옳다.
// 보안 문제도 있고 여러모로 않좋다.



namespace _18_TextRpg
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
		// 함수를 만드는 이유?
		// 기능을 전부 메인문 안에서 코드로 치면 복잡함.
		// 또한 반복되는 기능을 사용할 때 코드를 줄일 수 있음.

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
				Console.WriteLine("1. Recovery your HP\n2. Weapon enhancement\n3. Live town");
				switch (Console.ReadKey().Key)
				{
					case ConsoleKey.D1 :
						Console.Clear();
						_TownPlayer.Recovery_HP();
						break;
					case ConsoleKey.D2 :
						Console.Clear();
						_TownPlayer.Enhanced();
						break;
					case ConsoleKey.D3 :
						return;
					default :
						Console.Clear();
						Console.WriteLine("ERROR : There are no choice\n- Press any key -");
						Console.ReadKey();
						break;
				}
			}

		}
		static void Battle(Player _BattlePlayer)
		{
			Console.WriteLine("Hello, this is Fighters Club.\nWe are not open yet.\n- Press any key -");
			Console.ReadKey();
		}

		static int TenReturn()
		{
			return 10;
		}
		static void Main(string[] args)
		{
			int Number = TenReturn();
			STARTSELECT Select;
			Player NewPlayer = new Player();
			NewPlayer.GetName();
			Console.Clear();
			/*
			string Location;
			Console.WriteLine("Please choose location to go");
			Console.WriteLine("1. Town\n2. Fighter's Club");
			Location = Console.ReadLine();
			ㄴ 위에 키 무시
			*/
			// 객체화 하지 않고도 쓸 수 있는 함수
			// Static Function or 정적 멤버 함수
			while(true)
			{
				Select = StartSelect(NewPlayer);
				// C# 만든 사람 포함 프로그래머들은 대부분 이성적이고 직관적으로 이름을 지음.
				/*
				if (Select == STARTSELECT.SELECTTOWN)
				{
					Town();
				}
				else if (Select == STARTSELECT.SELECTBATTLE)
				{
					Battle();
				}
				else if (Select == STARTSELECT.SELECTSTART)
				{
					Console.WriteLine("We're already in Startzone.");
				}
				else
				{
					Console.WriteLine("ERROR : There has no Location");
				}
				*/
				switch (Select)
				{
					case STARTSELECT.SELECTTOWN :
						Console.WriteLine("We're heading to the Town...\n= Press any key -");
						Console.ReadKey();
						Console.Clear();
						Town(NewPlayer);
						break;
					case STARTSELECT.SELECTBATTLE :
						Console.WriteLine("We're heading to the Fighters club...\n- Press any key -");
						Console.ReadKey();
						Console.Clear();
						Battle(NewPlayer);
						break;
					case STARTSELECT.SELECTSTART :
						Console.WriteLine("We're already on Startzone");
						Console.WriteLine("- Press any key -");
						Console.ReadKey();
						break;
					case STARTSELECT.SELECTSHUTDOWN :
						Console.Write("Shutdown Program...\n- Press any key -");
						Console.ReadKey();
						return;
					default :
						Console.WriteLine("ERROR : There are not have location");
						Console.WriteLine("- Press any key -");
						Console.ReadKey();
						break;
				}
			}

				// Console.ReadKey => ConsoleKeyInfo 를 반환함.
				// ConsoleKeyInfo => 하나의 자료형이라고 생각하면 됨. 무슨 키를 눌렀는지 반환.
				// ConsoleKeyInfo => struct형.
				// Struct 형은 정적 멤버함수와 값 저장 가능.
				// ConsoleKey => enum 형태 value type
				// 왜 while 문을 이용했는가?
				// 키를 입력 받은 상태에 따라 반복되는 상황이 있어야 됨.
		}
	}
}

			

