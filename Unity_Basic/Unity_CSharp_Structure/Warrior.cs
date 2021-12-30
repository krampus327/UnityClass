using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_CSharp_Structure
{
    class Warrior
    {
        public Stats _stats;

        public void SetStats(int STR, int DEX, int CON, int WIS, int INT, int REG) 
        {
            _stats._STR = STR;
            _stats._DEX = DEX;
            _stats._CON = CON;
            _stats._WIS = WIS;
            _stats._INT = INT;
            _stats._REG = REG;
        }

        public void Print_Stats()
        {
            Console.WriteLine($"힘 : { _stats._STR}");
            Console.WriteLine($"민첩 : { _stats._DEX}");
            Console.WriteLine($"방어 :{_stats._CON}");
            Console.WriteLine($"지혜 :{_stats._WIS}");
            Console.WriteLine($"지능: {_stats._INT}");
            Console.WriteLine($"저항 : {_stats._REG}");
        }
    }

}
