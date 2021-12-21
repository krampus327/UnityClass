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

<<<<<<< HEAD
=======

>>>>>>> ed52ae42e5fe9d8e4cc25c5a2a27c44a5c737227
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
<<<<<<< HEAD

=======
>>>>>>> ed52ae42e5fe9d8e4cc25c5a2a27c44a5c737227
        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }
<<<<<<< HEAD
=======

>>>>>>> ed52ae42e5fe9d8e4cc25c5a2a27c44a5c737227
}
