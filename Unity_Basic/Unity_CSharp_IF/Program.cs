using System;

namespace Unity_CSharp_IF
{
    
    class Program
    {
<<<<<<< HEAD
        static bool condition1 = true; // 기본값 = false
        static bool condition2;
        static bool condition3;
        static void Main(string[] args)
        {
            if (condition1 == true)
                Console.WriteLine("조건1은 true");
            
            else if (condition2 == true)
                Console.WriteLine("조건2는 true");
            else
                Console.WriteLine("조건3은 true");
=======
        static bool doPrint = true; // 기본값 = false
        static void Main(string[] args)
        {
            if (doPrint == true)
            {
                Console.WriteLine("Hello");
            }
>>>>>>> ed52ae42e5fe9d8e4cc25c5a2a27c44a5c737227
        }
    }
}
