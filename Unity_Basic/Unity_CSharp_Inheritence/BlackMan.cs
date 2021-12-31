using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_CSharp_Inheritence
{
    class BlackMan : Person
    {
        public override void Breath()
        {
            lifeTime++;
            height += 0.00001f;
            weight += 0.00005f;

        }
    }
}
