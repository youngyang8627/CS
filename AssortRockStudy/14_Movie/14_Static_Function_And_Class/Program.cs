using System;

public class Player
{
	private int Hp = 100;
	int Att = 10;

	public static void PVP (Player _Left, Player _Right)// 이와같이 선언하면 Player.PVP() 등으로 바로 접근가능
	{
		// static 이 붙어있음
		// 정적 함수에는 큰 장점 존재.
		// 객체화를 하지 않아도 플레이어의 내부이므로 접근제한 지정자의 영향을 받지 않음.
		// ㄴ 서로 다른 obj끼리 접근가능;
		// 자기 자신의 레퍼런스는 자신의 내부에서 모두 public인 것.
		_Left.Hp -= _Right.Att;
		_Right.Hp -= _Left.Att;
	}

	/*
	static public void PVE(Player _Left, Monster _Right)
	{
		
		_Left.Hp -= _Right.Att;
		_Right.Hp -= _Left.Att;
		 ㄴ 위 코드는 작동되지 않는데 static이어도 Monster.Hp는 다른 클래스이므로 접근 불가
	}
	*/

	public void Damage(int _Dmg) // 지금 이 함수의 경우 객체(Object)를 선언 후 함수를 사용할 수 있음;
	// ㄴ 사용하기 위해선 Player NewPlayer = new Player(); 등을 작성해 객체를 선언 후 사용가능;
	{
		Hp -= _Dmg;
	}
	public void Attack (Monster _Monster)
	{
		_Monster.Hp -= Att;
	}

	public int Plus(int _a, int _b)
	{
		return (_a + _b);
	}
}

public class SidePlayer
{
	static public int StNumber;
	static public int PlayerCount; // <= 플레이어가 얼마나 있는지 저장하는 변수
	// ㄴ객체에 귀속된것이 아니라 클래스 그 자체에 귀속되고 메모리 중 데이터 영역에 들어감


	// none static => common member parameter
	// 이것들은 객체 하나하나가 자신의 것을 가짐 => 즉 공유를 하지 않음
	public int X = 0;
	public int Y = 0;
	private int Hp = 100;
	private int Att = 10;

	public void Attack (Monster _Monster)
	{
		_Monster.Hp -= Att;
	}
}

	public void Gravity()
	{
		
	}
}

public class Monster
{
	int Hp = 100;
	int Att = 10;

	/*
	static public void PVP (Player _Left, Player _Right)
	{
		_Left.Hp -= _Right.Att;
		_Right.Hp -= _Left.Att;
	}
	 ㄴ 위 코드는 사용불가
	    _Left.Parameter, _Right.Parameter 는 private이기 때문에 다른 클래스에서 접근 불가.
		private의 멤버변수는 해당 클래스에서만 수정 가능
	*/
	public void Damage(Player _Player)
	{
		_Player.Hp -= Att;
	}
}
namespace _14StaticFunctionAndClass
{
	class Program
	{
		static void Main(string[] args) // 이녀석도 클래스에 속한 함수이다.
		{
			Console.WriteLine("We're leaning static Function");
			// ㄴ 이녀석도 클래스에 속한 정적 함수이다;
			// 어떤 크래스에 존재하는 Main의 이름을 가진 정적멤버함수에서부터 C# 프로그램은 시작한다.
			// VS에서 F12를 누를 시 그 클래스로 타고 들어가 볼 수 있다.
			// 타고 들어간다? => 그 클래스의 세부내용이 기록된 곳으로 이동.
			// WriteLine 은 정적 멤버 함수. Console 이 클래스일 경우 객체화해야 사용가능. but 안함.
			// 따라서 Console.WriteLine은 객체화 안해도 되는 정적 멤버 함수.
			Player NewPlayer1 = new Player();
			Player NewPlayer2 = new Player();

			Player.PVP (NewPlayer1, NewPlayer2);
			// 클래스에 속하지만 객체를 굳이 만들지 않고도 사용할 수 있는 함수 => 정적 멤버 함수
			SidePlayer.PlayerCount = 3;
			// ㄴ 클래스 내부에서 모든 객체가 공유하고 싶은 변수 혹은 함수.
			// 게임 내에서 하나만 존재함;
			Console.WriteLine("static parameter the SidePlayer.PlayerCount = {0}", SidePlayer.PlayerCount);
			SidePlayer NewSPlayer1 = new SidePlayer();
			SidePlayer NewSPlayer2 = new SidePlayer();
			SidePlayer NewSPlayer3 = new SidePlayer();
			// ㄴ 여기서 
		}
	}
}
