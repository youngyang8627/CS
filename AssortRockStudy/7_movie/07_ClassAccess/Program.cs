using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
	// 클래스 선언 시 잘못쓰기도 힘들게 만들어놔라;
	// this is internal of class
	// 객체지향의 캡슐화 은닉화를 대표하는 문법OOP's Capsulization?
	// ex 접근제한 지정자
	// public private 등 지정자를 사용해 외부에서 접근 가능한지 파악;
	public int Hp; // 공개, 내가 치지 않은 코드에서도 접근 가능(보안 취약)
	protected int Att; // 자식에게만 공개(상속 배우면 알게됨)
	private int Def; // 내부에만 공개
	
	public void Fight() // 함수도 접근자와 제한자 적용 가능
	{
		Console.WriteLine("Player Fight");
	}
} // end of the class
// Outside of the class


namespace _07ClassAccess
{
	class Program
	{
		static void Main(string[] args)
		{
			Player NewPlayer_1 = new Player();
			NewPlayer_1.Hp = 1000;
			Console.WriteLine("{0}",NewPlayer_1.Hp);
			NewPlayer_1.Fight();
		}
	}
}
//만들어진 객체의 내용을 사용하기 위해서는
// 객체의 이름.'Content' 를 사용한다.
			
