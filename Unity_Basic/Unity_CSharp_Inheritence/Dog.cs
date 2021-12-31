using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_CSharp_Inheritence
{
    class Dog : Creature, iFourLeggedWarker
    {
        public float tailLength;

        public void FourLeggedWalker()
        {
            Console.WriteLine("네 발로 걷는다.");
        }
    }
}
