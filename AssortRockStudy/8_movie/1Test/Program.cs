using System;

// in OOP
// You should first to do
// When you want to make a RPG;
// If you want to make a monster;
/* 
Class Dragon
{
	int AT; // Declaration Member Parameter;
	int Hp;
	void Damage()	
	{
		Hp = Hp - 10;
	}
}
*/
class Player
{
	// this is blueprint. It can't use just only this
	// parameter's defalut is private;
	// 기본적으로 private 형의 자료를 더욱 많이 선언.
	// 그러면 접근은 어떻게 하느냐? => 함수를 통해서 접근.
	// 속성들은 일반적으로 외부에서 접근하지 않는게 좋다.
	// 왜? 만약 접근할 수 있다면 보안에서 취약. 아무나 수정 가능해서 버그 및 악용 가능성
	// 공격력은 공격력 그 자체만으로 의미가 있지만
	// 그 의미가 명확해지지 않는다.
	private int Att;
	private int Hp;
	private int LV;
	public void SetHp(int _Hp)
	{
		// 조건문을 배우면 _Hp에 따라 다양한 행동을 취할 수 있음 ex ) if (_Hp == 0){ Dead(); }
		Hp = _Hp;
		LV = 1;
	}
	// 각각 증가시키거나
	// 어떤 상태가 변화하는 순간

	public int GetLv() // When you want to know player's level
	{
		return (LV);
	}
		// return value ? => 객체가 자신의 상태를 외부에 알려주는 용도로 사용한다.
		// 외부에 알려줘야 하기 때문에 알려주는 순간 함수가 종료됨.
		// return 문장을 사용하게 되면 뒤에 무슨 코드가 있던 바로 종료
		// Return value must be same type of function

	public void LVup()
	{
		Att += 10;
		Hp += 10;
	}
	public void Damage_1(int _Dmg)
	{
		Hp = Hp - _Dmg;
		Console.WriteLine("Player taken Damage {0}\nHp left = {1}", _Dmg, Hp);
	}
	public void Damage_2(int _Dmg, int _SubDmg)
	{
		Hp = Hp - _Dmg - _SubDmg;
		Console.WriteLine("Player taken Damage twice! {0} {1}\nHp left = {2}", _Dmg, _SubDmg, Hp);
	}
	// 함수란 보통 클래스 외부와의 소통을 위해 만듬.
	// Damage는 맞는다라는 뜻
	// (int _Dmg)를 넣는다는 것은 외부에서 한개의 int를 전달해 주어서 플레이어에게 전달하겠다.
	// 인자값의 갯수는 다양. ( 최소 100개 이상 )

}

// Function can explain Declaration and Content;
// [Return value type] [Name or Identifier] ([Index value])

namespace _08FuncEx
{
	class Program
	{
		static void Main(string[] args)
		{
			Player NewPlayer_1 = new Player();
			// NewPlayer_1.Hp = 100; <= If Hp parameter was public, other programmer can modify parameter easily
			// ㄴWhen Hp parameter was public.
			/* if levelup
			따로 쓰기에는 복잡하고 불편함
			NewPlayer_1.Att += 1;
			NewPlayer_1.Hp += 1;
			Also when you use Function, than you can debug easier than just modify value directly
			*/
			// 이런식으로 외부의 값을 받아서 객체가 내부의 상태를 변화시키기 위해서 함수를 선언하는 경우가 많음;
			NewPlayer_1.SetHp(100);
			NewPlayer_1.Damage_1(10);
			NewPlayer_1.Damage_2(10, 15);
			Console.WriteLine(NewPlayer_1.GetLv());
		}
	}
}
