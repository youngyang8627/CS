using System;

struct StructData
{
	// It is simular than class but has diffrent that something doesn't work
	// = 0 안된다.
	// literal initialization 안됨
	/* 
	int a = 0;
	int b = 0;
	*/
	// 위에꺼 안됨
	public int a;
	public int b;
	// 위처럼 선언 가능 및 기본으로 = 0 붙음.

	public void Func()
	{
		a = 100;
		b = 100;
	}
}

namespace _17Struct
{
	class Program
	{
		static void Test(StructData _Data)
		// ㄴ 여기서 StructData를 가져온 게 아니라 _Data라는 것으로 값을 복제해 새로 생성하게 된것.
		{
			_Data.a = 1000;
			// ㄴ 따라서 여기서 수정하더라도 밖에 있는 걔는 변경되지 않는다.
		}
		static void TestNumber(int _Num)
		{
			_Num = 1000;
		}
		static void Main(string[] args)
		{
			int Number = 100;
			StructData Newdata = new StructData();
			Newdata.a = 100;
			Newdata.b = 200;
			Test(Newdata);
			TestNumber(Number);
			Console.WriteLine(Newdata.a);
			Console.WriteLine(Number);
			// 클래스를 객체화 했을 때는 그것은 참조형(Reference)
			// ㄴ 실체가 stack 영역에 없기 때문에 실제로 있는 게 아니라 주소를 가리키는것.
			// ㄴ 클래스를 다른 함수에서 호출했을 때 혹은 받았을 때도 마찬가지.
			// 구조체를 선언하면 그것은 값형.
		}
	}
}
