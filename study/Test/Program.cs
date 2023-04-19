using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//2. 초기화 되지 않은 멤버 번수
			Test testA = new Test("A Object");
			testA.Show();
	
			Test testB = new Test(1, 3);
			testB.Show();
	
			//4. 참조가 끊겨 가비지가 되었음
			testB = null;

			//6.call Garbage collecter
			System.GC.Collect();
			Console.WriteLine();
			Console.WriteLine("Calling Garbage Collecter...");
			Console.WriteLine();

			Console.WriteLine("Shallow Copy testA to test C & change value of nNum1 and nNum2");
			//ㄴ 얕은 복사라는 뜻
			Test testC = testA;
			testC.nNum1 = -10;
			testC.nNum2 = -30;
			Console.WriteLine("testA's nNum1, nNum2 value");
			testA.Show();
			Console.WriteLine("testC's nNum1, nNum2 value");
			testC.Show();
			Console.WriteLine();
		}
	}
	class Test
    {
        public int nNum1 = 100;
        public int nNum2;
        string sName = "Object";

        public Test()
        {
            Console.WriteLine("Test() execution");
        }
        //1. 생성자의 오버로딩
        public Test(string name)
        {
            sName = name;
            Console.WriteLine(sName + " producted!");
        }
        //3. 이름이 동일한 변수이지만, this 키워드를 사용하여
        //  자기 자신의 instant에 접근
        public Test(int nNum1, int nNum2)
        {
            this.nNum1 = nNum1;
            this.nNum2 = nNum2;
        }
        ~Test()
        {
            Console.WriteLine("{0} nNum1 : {1}, nNum2 : {2}", sName, nNum1, nNum2);
        }
        public void Show()
        {
            Console.WriteLine("{0} nNum1 : {1}, nNum2 : {2}", sName, nNum1, nNum2);
        }

        //5. 깊은 복사
        //  새로운 인스턴스를 생성해 클론을 만듭니다.
        public Test GetClone()
        {
            Test newInstance = new Test("Clone Object");
            newInstance.nNum1 = this.nNum1;
            newInstance.nNum2 = this.nNum2;

            return newInstance;
        }
	}
}
