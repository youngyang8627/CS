using System;

class Player
{
	private int Hp = 100;
	private static int StTest = 100;
	
	public void Damage(int _Dmg)
	{
		// C#은 대체 어떻게 이 hp가 플레이어2의 hp라는 것을 알 수 있을까??
		// this 
		Hp -= _Dmg;
		// ㄴ NewPlayer_2.Damage(100)을 했을 때 어떻게 플레이어 2의 Hp라는 것을 알 수 있을까?
	}
	// ㄴ 아래 함수는 위와 같은기능을 수행함.
	// Player2에다 사용할 때는 Player.Damage(Newplayer_2, Damage_value);
	public static void Damage_2(Player _this, int _Dmg)
	{
		_this.Hp -= _Dmg;
		// static에는 그냥 Hp를 사용 불가능.
		// why? because static Function has not 'this' class.
		// becaus static function can run without Object.
	}
	// 정적 멤버 변수만을 쓸 수 있음.
	static void PVP (Player _Left, Player _Right)
	{
		// Hp = 1000; <= 불가능. static 자체는 객체가 없어도 되나 전역변수는 객체가 있어야 함.
		// 게다가 누구의 Hp인지 표현도 안됨. 그래서 못씀.
		// 객체에 영향을 받지 않는것이 정적 멤버함수, 정적 멤버변수
		
	}

	// 멤버함수의 호출이란 우리에게 보여지지 않지만 어짜피 넣을것 매번 자기 자신 호출 후 시작.
	public void Heal(/*Player this, */int _Heal) // this는 자동으로 들어간다고 생각하면 됨.
	{
		// 멤버함수에서 멤버 변수를 쓴다면 눈에 보이지는 않지만 앞에 this. 이 생략된것.
		this.Hp += _Heal;
		// ㄴ 위에 this 가 있다는 것을 인지해야하나, 그냥 Hp라고 해도 위에 Hp라고 알고 있기 때문에 가능.
		//    코드를 치기 편하게 발전해서 생략 가능.
		// *** 객체지향의 핵심 중 하나***
	}
}

namespace _15ThisReference
{
	class Program
	{
		static void Main(string[] args)
		{
			Player NewPlayer_1 = new Player();
			Player NewPlayer_2 = new Player();
			Player.PVP(NewPlayer_1, NewPlayer_2);
			NewPlayer.Damage(10);
			NewPlayer_2.Damage(10);
			// this 가 없을 시 매번 호출할 때 자기 자신을 넣어줘야됨.
			// this 는 현재 객체를 가리킴
			// NewPlayer_2(NewPlayer2, 100);
			Player.Damage_2(NewPlayer_2, 10);
			// 위에 함수와 똑같은 기능
		}
	}
}
