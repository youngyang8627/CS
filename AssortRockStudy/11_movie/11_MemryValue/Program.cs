using System;

class Player
{
	int Hp = 100;
	int Att = 10;

	public void Test(int _Dmg)
	{
		_Dmg = 1000;
	}

	public void Damage(int _Dmg)
	{
		Hp -= _Dmg;
	}

	public int Plus(int _a, int _b)
	{
		return (_a + _b);
	}
}

namespace _11MemoryValue
{
	class Program
	{
		static void Main(string[] args)
		{
			int Value = 0;
			Player NewPlayer = new Player();
			NewPlayer.Test(Value);
			/*
				Value에 들어가는 값은 0;
				why? => 값과 위치에 대하여 알아야 됨
				Test 내부의 _Dmg => 메모리에 저장되는 위치값이 value와 다름;
				Value => Main 소속, _Dmg => Test 소속;
				ㄴ 둘 다 Stack 영역에 저장
				NewPlayer.Test(Value) => 이 뜻은 값만 넘긴것, 주소를 넘기지 않았기 때문에
				다른 곳에서 수정이 불가능;
				하는 방법 2가지
				int Test로 변경 후 return _Dmg; Value = NewPlayer.Test(Value); => 값형의 처리
				int* P = &Value; 로 주소값 저장 후 Test(int* _Dmg)로 받은 뒤 *_Dmg = x; 로 처리 => 주소로 처리

			*/
		}
	}
}
