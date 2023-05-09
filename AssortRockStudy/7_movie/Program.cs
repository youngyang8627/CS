using System;

// 세세하게 생각을 해야 어떤 기능을 만들지 정할 수 있다.
// 아래처럼
// 어떤 행동을 하는지, 어떤 자원을 소모하는지;

//플레이어가 하는 행동?
// 공격, 이동, Idle 등등...
// 지형에서 움직인다.
// Npc와 대화한다
// 스킬을 적에게 사용한다.

// Member Method;
// 언제 어떻게 선언 후 응용?
// Local Parameter? => 

// 클래스 안에 내용을 채워넣음으로써 객체지향을 완성
class Player
{
	int Att;
	int Hp;
	//int Hp;  <= The int 'Hp' name has taken already. so it cause error;
	
	void Talk()
	{
		//Content;
	}

	void SkillUse()
	{
		//Content;
	}

	void Fight() // <
	{
		//Content;
	}

	void Move()
	{
		//Content;
	}

	void Attack() // void => return value, Attack => Function name;
	{
		//Content;
	}
}

// Also function contained to memory.
// 이것들처럼 기능을 만드는 것을 함수;

// make RPG => make Project;
// is exist Player => make class Player;
// Player has Attack value(number) => Member Parameter;
// Player Attack Monster => Member Function(Method);
