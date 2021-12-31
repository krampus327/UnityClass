using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_CSharp_Inheritence
{
    class Person : Creature , iTwoLeggedWarker
    {
        public float height;

        // override : 부모의 virtural 키워드가 있는 함수를 재정의 하는 키워드
        // 
        public override void Breath()
        {
            base.Breath();
            height += 0.00004f;
            weight += 0.00002f;
        }
        
        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }
}
