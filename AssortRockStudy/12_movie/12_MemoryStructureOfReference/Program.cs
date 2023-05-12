using System;

class Monster
{
	public int Hp = 100;
	public int Att = 10;

	public void Att1 (Player _Player)
	{
		// How much Player's Hp?
		// 100 - 10 = 90;
		// It can be modified because Att1 Function has access to Player's Address;
		// 이 녀석은 클래스가 객채화 된것을 받음
		_Player.Hp -= Att;
	}
	public void Test(int _Test)
	{
		_Test = 1000;
	}
}


class Player
{
	public int Hp = 100;
	public int Att = 10;
	
	public void Att1 (Monster _Monster)
	{
		_Monster.Hp -= Att;
	}

	public int Plus (int _a, int _b)
	{
		return (_a + _b);
	}
}

namespace _12MemoryReference
{
	class Program 
	{
		static void Main(string[] args)
		{
			int Value = 0;
			Monster NewMonster = new Monster();
			Player NewPlayer = new Player();
			/*
				ㄴ 위같이 객채의 경우에는 heap 메모리에 저장됨;
				new 명령어를 사용했을 땐 heap에 저장됨;
				NewPlayer[ NewPlayer.Hp = 100, NewPlayer.Att = 10... public int Plus(int a...]
				 ㄴ contain Parameter, Method;
				Reference <= Heap 에 생성된 메모리의 위치를 가리키는 값;
				NewPlayer.Hp 에서 '.' 의 의미?
				 = 내가 가리키고 있는 위치에 있는 변수 혹은 함수를 사용하겠다.
				그림으로 그려보면서 논리적 사골ㄹ 통해 함수와 레퍼런스가 어떻게 작용하는지 알아둘것;
				값형과 레퍼런스 구분 가능해야함.
				기본 자료형은 선언 시 값형. new class() 해서 만든것을 class형에 받으면 reference형
				힙에는 객체들의 본체(new를 통해 만들어진 것)가, 스택에서는 함수의 실행 메모리 및 지역변수 저장.
			*/
			NewMonster.Att1(NewPlayer);
			Console.WriteLine(NewPlayer.Hp);
			NewPlayer.Att1(NewMonster);
			Console.WriteLine(NewMonster.Hp);
			NewMonster.Test(Value);
			Console.WriteLine(Value);
			// 위 코드는 플레이어가 자신의 공격력으로 몬스터를 때림.
			// ?? why it can change?
			// Because when you transmission class that Objective, It be a reference type.
			// Value type and Reference type is diffrent that using area. so they run diffrently.

		}
	}
}
