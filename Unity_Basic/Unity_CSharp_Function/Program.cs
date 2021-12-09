using System;

namespace Unity_CSharp_Function
{
    class Program
    {
        static bool doPrintHW = true;
        static void Main(string[] args)
        {

            if (doPrintHW == true)
                PrintHelloWorld();
            else
                Console.WriteLine("false");


            // parameter : 함수호출 시 입력 변수
            string a = "aaaa";
            if (doPrintHW == true)
                PrintSomething(a);
            else
                Console.WriteLine("false");
        }


        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }

}
