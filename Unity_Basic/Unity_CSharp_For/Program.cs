using System;

namespace Unity_CSharp_For
{
    class Program
    {
        static void Main(string[] args)
        {
            // collection - 동적 데이터 타입
            // List, Dictionary, Stack, Queue



            string[] arr_PersonName = new string[6];

            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "강아무개";
            arr_PersonName[2] = "감아무개";
            arr_PersonName[3] = "이아무개";
            arr_PersonName[4] = "임아무개";
            arr_PersonName[5] = "암아무개";
            int length = arr_PersonName.Length;
            // for문의 형태
            // for( 인덱스용 변수 선언 및 초기화 ; for문을 실행할 조건 ; 루프가 한번 실행 될 때마다 실행할 구문)

            for (int i = 0; i < length; i++)
            {
                if (arr_PersonName[i] == "강아무개")
                    Console.WriteLine(arr_PersonName[i]);
            }

            //2n(n은 양의 정수) 마다 김아무개 라는 규칙을 활용한 예제
            for (int i= 0; i < length; i+=2)
            {
                Console.WriteLine(arr_PersonName[i]);
            }

        }
    }
}
