using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_CSharp_Inheritence
{
    class Creature
    {
        public string DNA;
        public int lifeTime;
        public float weight;

        // 함수 오버라이딩 ( override )
        // 베이스 함수를 확장하는 기능
        // 함수를 재정의 하는 기능

        // virtual 키워드 : 해당함수를 오버라이딩 가능하도록 해준다.(자식클래스에서 재정의가 필요할때)
        // 부모클래스 함수라고해서 전부 virtual 붙이는게 아니라,
        // 자식클래스가 해당 함수를 재정의 해야할 때만 virtual을 붙여준다.


        virtual public void Breath()
        {
            lifeTime++;
        }
    }
}
