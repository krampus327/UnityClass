// using 키워드 
// 미리 구현해둔 코드를 사용하고자 할 때 사용
// 우선순위가 차순위인 함수 호출
// RayCast()를 포함하는 두 네임스페이스들 중 차순위 네임스페이스를 호출하고싶을 때
//   --> using RayCast = Unity.Physics.RayCast()  

using System;

// namespace 키워드
// 충돌을 방지하기 위해 사용
namespace Unity_Program
{

    // 모든 프로젝트는 Main함수를 가장먼저 실행한다.
    // C#에선 main함수도 program이라는 클래스에 선언되어있다.

    class Program //
    {
        // static 키워드
        // dynamic(동적) 의 반대개념 키워드 static(정적)
        // static은 상황에따라 메모리에 할당할 수 없지만
        // dynamic은 상황, 조건에따라 메모리에 할당할 수 있다.

        // args = arguments (인자, 인수)
        // 함수에서 받을 입력 
        // 표기방법은 함수이름 뒤에 괄호열고 "자료형" "인자이름"형태
        //main함수는 static으로 정의되어 있기 때문에 하나만 선언할 수 있다.
        // void 자료형 -> 반환값이 없다.
        // 일반적인 함수 : 입력 -> 기능수행 -> 출력
        // void 함수 : 입력 -> 기능수행
        static void Main(string[] args)
        {
            //Console? -> System에서 선언된 클래스
            Console.WriteLine("Hello World!");


        }
    }
}
