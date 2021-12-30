using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_CSharp_Structure
{
    class Equipment
    {
        // 아래 장비 능력치들을 EquipmentAbility라는 구조체로 정의하고
        /* public int _ATK;
         public int _DEF;
         public int _HP;
         public int _MP;
         public int _Durablibity;*/
        // Stats형 멤버변수도 정의한다.

        public Stats equipStats;
        public EquipmentAbility _equipmentAbility;


        public void Equip_Stats(int ATK,int DEF, int MP,int Dur)
        {


        }
       
    }
}
