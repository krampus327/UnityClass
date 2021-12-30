using System;
// structure - 구조체
// 변수들의 집합을 하나의 자료형으로 표현
// 변수들을 여러가지를 써야할때 해당 변수를 사용한 곳이 많거나
// 변수집합의 요소가 너무 많아서 묶어서 따로 분리해야 가독성과 관리가 편할것 같을때 사용.
// 구조는 클래스에서 함수가 빠진것과 같음


namespace Unity_CSharp_Structure
{
    class Program
    {

        static void Main(string[] args)
        {
            // 객체의 구조체 멤버변수의 멤버를 초기화
            Warrior warrior = new Warrior();
            warrior._stats._STR = 10;
            warrior._stats._DEX = 20;
            warrior._stats._CON = 30;
            warrior._stats._WIS = 40;
            warrior._stats._INT = 50;
            warrior._stats._REG = 60;
            

            // 객체의 구조체 멤버변수를 초기화
            Stats stats_Warrior = new Stats();
            stats_Warrior._STR = 100;
            stats_Warrior._DEX = 200;
            stats_Warrior._CON = 300;
            stats_Warrior._WIS = 400;
            stats_Warrior._INT = 500;
            stats_Warrior._REG = 600;

            Warrior[] arr_Warrior = new Warrior[10];
            int length = arr_Warrior.Length;
            for(int i = 0;i<10;i++)
            {
                arr_Warrior[i] = new Warrior();
                arr_Warrior[i]._stats = stats_Warrior;
            }

            for(int i = 0; i < 10; i++)
            {
                arr_Warrior[i].SetStats(100, 200, 300, 400, 500, 600);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("--------------------------------");

                arr_Warrior[i].Print_Stats();
                
                Console.WriteLine("--------------------------------");
            }





        }
    }
    
}
