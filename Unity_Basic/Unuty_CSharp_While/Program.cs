using System;

namespace Unuty_CSharp_While
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 문의 구조
            //while(true) // 무한루프 : while문의 조건이 항상 참일 경우
            //{
            //조건이 참이면 반복할 내용
            //   Console.WriteLine("Hello");
            //}
            // 조건이 항상 참이면 무한으로 돌아가기 때문에
            // 더이상 진행하지 못하고 프로그램이 멈추는 현상이 발생한다.
            // 그러므로 while문은 탈출할 수 있는 조건을 입력해야한다.

            string[] arr_PersonName = new string[3];

            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "강아무개";
            arr_PersonName[2] = "감아무개";
            int length = arr_PersonName.Length;
            int cnt = 0;
            //while(cnt<length) 
             //   Console.WriteLine(arr_PersonName[cnt++]);

            while (true)
            {
                if (cnt < length)
                    Console.WriteLine(arr_PersonName[cnt++]);
                else
                    break;
            }
        }
    }
}
