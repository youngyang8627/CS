using System;

namespace _23eInheritance
{
    // Inheritance?
    // increase efficiant to recycling code
    // 똑같은 코드 2번 치기 싫다. 함수도 마찬가지.
    // 어떤 계열이 있는지 파악하는 감이 필요.
    // ex ) player 와 monster 는 싸우기 위해 필요한 애들이 아닐까?
    // 물리 엔진 같은 공통적인 기능을 하는 것도 묶을 수 있을듯? ex ) 중력, 마찰력 등...
    // 방법은 공통되는 기능을 하는 멤버변수와 멤버함수를 걷어낸다.
    // 겹치는 부분을 만들어 클래스로 따로 만듦
    // C#에서 클래스상속이란 오직 하나만 사용 가능하다.
    // ㄴ 다른 언어에서는 여러개 상속받는 경우도 있음(C++)
    // but 상속받은 클래스에서 상속한 클래스의 private 멤버변수나 멤버함수를 불러올 수는 없음.
    // but protected 의 경우에는 가능.

    class Fightunit
    {
        //       public      protected      private
        // 범위   외부까지  >     자식까지    >    나까지
        protected int Hp;
        protected int At;
        public void Damaged(/*Fightunit this,*/ Fightunit _OtherUnit)
        {
            this.Hp -= _Dmg;
        }

    }
    class Player : Fightunit // 상속하는 법. 내려준다고도 한다.
    {
        int Lv = 1;

        void Heal()
        {
            Hp = 100;
        }
    }
    class Monster : Fightunit // <= 클래스 이름 : 상속_클래스 할 시 상속됨.
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player NewMonster = new Monster();
            NewPlayer.Damaged(NewMonster);
            NewMonster.Damaged(NewPlayer);
            // 같은 기능을 상속이 되어있으면 다른 클래스(오브젝트)에서도 사용가능.
            /*
                Fightunit FU = NewPlayer;
                NewPlayer.Damaged(FU);
                위랑 아래는 기능 자체는 같지만 FU는 NewPlayer에서 Fightunit 부분만 떼어냄.
                업캐스팅이라고 함. 자식이 부모형이 되면서 자식의 능력을 버림.
            */
            /* 
                반대로 다운캐스팅은 부모 클래스가 자식 클래스로 변경됨.
                Fightunit FU = new Fightunit();
                Player OtherPlayer = _OtherUnit;
                하지만 되도록 위 방법은 사용하지 않는것이 좋음.
                객체가 
            */
            // 메모리 구조를 이해할 수 있다면 왜 되고 왜 안되는지 이해할 수 있음.
            // 상속의 메모리 구조는 상속되는 클래스 | 상속받는 클래스 부분이 있음.
            // 상속 안한 클래스는 해당 클래스의 정보만 메모리에 저장하지만, 상속한 클래스가 있으면
            // 상속한 클래스 + 해당 클래스 의 정보를 메모리에 저장.
        }
    }
}