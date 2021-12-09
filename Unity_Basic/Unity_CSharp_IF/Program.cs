using System;

namespace Unity_CSharp_IF
{
    
    class Program
    {
        static bool doPrint = true; // 기본값 = false
        static void Main(string[] args)
        {
            if (doPrint == true)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
