using System;

// 기본 자료형 -> 이미 있는것.
// int, string, double ...
// 사용자가 만드는 자료형(정의하는 자료형)
// class, struct 등
// enum? => 열거자. 보통 어떤 상태를 표현하는 것중 나만의 것을 가지고 싶을 때 사용.
// C++, Java 등 다양한 곳에서 쓰는 것과 C# 에서의 enum 은 다름.
// C# 외 다른 언어에서는 정수로 저장됨.
// but C# 에서는 상수로 저장됨.
// enum의 좋은점? => switch 사용하기에 정말 좋음.
// 이게 끝은 아니고 어느정도 enum에 관해 배움.
// 값제한 씹가능.

public enum ItemType
{
	Equip,
	Potion,
	Quest,
	None
}
// 위 아이템들의 기능을 만들 때 클래스를 보통 하나만 만들어 사용
// 아이템이 수백개가 있을 때도 멤버변수로 보통 처리
// enum을 사용하게 되면 하나의 case를 만들 수 있음. 명찰에 가까운 개념
class RpgItem
{
	public ItemType Type = ItemType.None;
	// ㄴ 위처럼 아이텡타입을 정수로 지정했을 때 가독성이 씹창남.
	public void PotionTypeSetting()
	{
		Type = ItemType.Potion;
	}
}
class Player
{
	
}
namespace _17Enum
{
	class Program
	{
		static void Main(string[] args)
		{
			RpgItem NewItem = new RpgItem();
			NewItem.Type = ItemType.Potion;
			// enum은 값형이고 사용방법을 제외하고 int와 비슷.
			Console.WriteLine(ItemType.Potion);
			/*
			switch (Type)
			{
				case ItemType.Equip :
				{
					Content;
					break;
				}
				...
			}
			*/
		}
	}
}
