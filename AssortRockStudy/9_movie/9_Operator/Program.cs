using System;

class Player
{
	int Hp;
	int Att;

	void Damage(int	_Dmg)
	{
		Hp = Hp - _Dmg;
	}

	public int Plus(int _Left, int _Right)
	{
		int Result;
		Result = _Left + _Right;
		return (Result);
	}
}

namespace _09_Operator
{
	class Program
	{
		static void Main(string[] args)
		{
			int Result = 0;
			int Left = 3;
			int Right= 7;
	
			Player NewPlayer = new Player();
	
			// = 대입 연산자. 저장할 수 있는 변수에다 return값을 넣어주거나 해당하는 값을 대입시켜줌
			// 산술연산자 = 함수와 비슷. 리턴값으로 해당 연산자에 맞는 연산을 해주고 값을 리턴해줌
			// x = a + b; 가 있을 때 오른쪽이 먼저 실행되고 왼쪽에 return하는 식.
			// 산술연산자는 *, /, % 가 먼저 연산되고 +, -  가 연산됨
			Console.WriteLine("Current Result = {0}, Left = {1}, Right = {2}", Result, Left, Right);
			Result = NewPlayer.Plus(Left, Right);
			Console.WriteLine("Left + Right = {0}", Result);
			Result = Left - Right;
			Console.WriteLine("Left - Right = {0}", Result);
			Result = Left * Right;
			Console.WriteLine("Left * Right = {0}", Result);
			Result = Left / Right;
			Console.WriteLine("Left / Right = {0}", Result);
			Result = Left % Right;
			Console.WriteLine("Left % Right = {0}", Result);
			Result = 2 + 2 * 2;
			Console.WriteLine("2 + 2 * 2 = {0}", Result);
			// 논리 연산자는 bool type 로 반환되며, 조건이 맞으면 true, 아닐경우 false를 반환;
			// 100, 200 => 정수형 상수. bool에는 참과 거짓이 있는데, 참과 거짓이 상수화 된것이 true 와 false;
			//
			bool Bresult = true;
			Bresult = false;
			Console.WriteLine("Bresult = {0}", Bresult);
			Bresult = Left < Right;
			Console.WriteLine("Left < Right = {0}", Bresult);
			Bresult = Left > Right;
			Console.WriteLine("Left > Right = {0}", Bresult);
			Bresult = Left <= Right;
			Console.WriteLine("Left <= Right = {0}", Bresult);
			Bresult = Left >= Right;
			Console.WriteLine("Left >= Right = {0}", Bresult);
			Bresult = Left == Right;
			Console.WriteLine("Left == Right = {0}", Bresult);
			Bresult = Left != Right;
			Console.WriteLine("Left != Right = {0}", Bresult);

			// bool 논리 연산자
			// bool 논리 연산자는 참과 거짓을 연산하는 연산자
			// 참과 거짓 값을 받아와 그걸 가지고 연산함.
			// ㄴ둘다 맞다면, 둘다 틀리다면, 둘중에 하나만 맞아도 등등.
			// AND, OR, NOR, XOR, NOT 등등;
			Bresult = !(Left < Right); // If true, change false
			Bresult = true && false;
			// ㄴ AND : 연속되어 있을 때 하나만 false일 경우 false
			Bresult = true || false || false;
			// ㄴ OR : 연속되어 있을 떄 하나만 true일 경우 true
			Bresult = true ^ false;
			// ㄴ XOR : 값이 각각 다르다면 true, 같다면 false;
			
			// 축약 연산자
			Result = 0;
			Result += 10;
			Result -= 2;
			Result /= 2;
			Result *= 3;
			Result %= 2;
			Console.WriteLine("Result = (0 + 10 - 2) / 2 * 3 % 2 = {0}", Result);
		}
	}
}

