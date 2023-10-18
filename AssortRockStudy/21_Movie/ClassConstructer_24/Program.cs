using System;

class FightUnit
{
    protected int At;
    protected string _Name;
    public FightUnit()
    {
        int Number = 0;
    }
}
class Player : FightUnit
{
    // 생성자. 특징 : 리턴값 없음. ********** 중요 ***********
    // 눈에 보이지 않지만, 클래스 생성 시 자연스레 아래 public Player() 함수 생성됨.
    // 생성자 호출 시 (new 할 때) 제일 먼저 실행됨. 문법상 ClassName NewClassName = new ClassName();
    // 문법적으로 자신의 클래스를 리턴해줌.
    // 접근 제한 지정자는 있음 => 만들수도 없게 설정 할 수도 있음.(private, protected). 의미가 있다.
    // 만드는 순간 바로 해야되는 기능들은 생성자에서 바로 해주는게 좋다. ex) 이름 설정, 초가값 설정 등...
    // 특히 초기값을 강제해 줄 수 있음.
    // RPG 프로젝트만 올려놓아야된다?? => 
    // 숙제? => 둘 중 누군가 죽을 때까지 + 수단과 방법을 가리지 말고 상대방과 싸우게 만들어봄.
    // => 1. 한쪽이 죽으면 먼저 싸움을 끝냄(startpoint로 나감)
    // => 2. 마을로 이동
    public Player(string _name)
    {
        _Name = _name;
        At = 100;
        int Number = 0;
        Console.WriteLine("Your name is " + Oname);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
class Monster : FightUnit
{
    public Monster(string _Name)
    {

    }
}

namespace _24ClassConstructer
{
    class Program
    {
        static void Main(String[] args)
        {
            string Temp;
            Console.WriteLine("Please type your name");
            Temp = Console.ReadLine();
            Player NewPlayer = new Player(Temp);
        }
    }
}