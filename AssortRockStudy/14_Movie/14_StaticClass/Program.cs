using System;

static class StClass
{
	// 클래스 앞에 클래스가 붙음. => 정적만 넣을 수 있음
	// 정적 클래스 => 정적 멤버변수와 정적 멤버함수만을 가질 수 있는 클래스
	public static int Test = 10;
}

class Player
{
	static void Main(string[] args)
	{
		//함수의 위치는 문법적으로 어디에 있던 상관 없다. 구조적으로 이야기 하는것이 아니라.
		Console.WriteLine("Console.WriteLine is static Function");
		Console.WriteLine("{0}", StClass.Test);
	}
}
