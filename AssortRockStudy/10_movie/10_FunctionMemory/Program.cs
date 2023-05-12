using System;

class Player
{
	int Hp = 100;
	int Att = 10;
	int Def;

	void Damage(int _Dmg)
	{
		Hp -= _Dmg;
	}

	int PlusNumber(int _a, int _b)
	{
		return (_a + _b);
	}
}

namespace _10FunctionMemory
{
	class Program
	{
		static void Main(string[] args) // <= 이녀석을 메인 함수라고 함. static 빼고 함수 모양을 지님
		// C#은 이곳을 시작 함수로 규정 Main() 
		// Main 실행 시 Stack 영역에 Main 함수 올라감
		{
			// make Object == Computer paid Memory;
			// No Pay, No Gain;
			Player NewPlayer = new Player(); // Class 선언시에도 stack 중 선언한 함수 내에 할당됨. 크기와 값은
			//									추후 설명

			/*
				메모리는 대략 2차원 표와 비슷.
				4GB 만큼 있다하면 bit(0,1) 가 8 * 10^9 개 있다는 것.
				프로그램을 만들고 실행하면 램에 총 4개의 구분 공간으로 할당됨;
				코드	: 상수, 클래서 선언, 함수의 내용처럼  수정이 불가능한 녀석들이 들어감
				데이터	: 지금 설명 안함;
				힙		:
				스택	: 함수가 실행될 때 stack에 저장됨  (재귀 함수 같은거 할 때);
				프로그램을 끌 때 메모리를 Free 해주고 끝남.
				함수는 메모리화 되지 않는다? => 크기는 지역변수 + a 로 계산됨.
				ex ) Main안에 int가 하나 있다 => 최소 4byte 이상.
				Console.WriteLine 등등도 호출 시 Stack에 할당되었다가 작업이 끝나면 사라짐.
			*/
			NewPlayer.Damage(10); // 함수의 인자값은 지역변수이다. 지역변수 특 함수 끝나면 사라짐.
		}
	}
}
