using System;

namespace Unity_CSharp_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체 생성 new키워드
            new AA(); // 생성자 : 클래스이름과 똑같은 함수

            // 인스턴스화
            //메모리 공간에 객체를 할당시킨다.
            //AA 타입의 변수 a에 new AA()로 생성된 객체가 할딩 되었다.
            //이제 new AA()로 생성된 객체가 필요할떄마다 변수 a를 통해서 접근할 수 있게 되었다.
            //이렇게 되었을 때 new AA()로 생성된 객체를 인스턴스 라고 한다.

            AA a = new AA();
            

           

        }
    }

    
    public class AA
    {

    }

}
