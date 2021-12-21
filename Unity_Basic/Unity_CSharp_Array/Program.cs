using System;

namespace Unity_CSharp_Array
{
    class Program
    {
        // 배열
        // 형태 : 자료형[]
        // 자료형이 정적으로 나열되어있는 형태, 크기를 한번 정해두면 바꿀 수 없다.

        static int[] arr_testInt = new int[5];
        static float[] arr_testFloat = new float[5];
        static float[] arr_testFloat22 = { 1.0f, 2.0f, 3.0f };

        static string[] arr_testString = new string[4];

        static TestClass[] arr_testClass = new TestClass[4];  // TestClass의 객체를 나열할때 사용
        static void Main(string[] args)
        {
            Console.WriteLine("int");
            for (int i = 0; i < 5; i++)
                arr_testInt[i] = i+1;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr_testInt[i]);

            Console.WriteLine();

            Console.WriteLine("float");
            for (int i = 0; i < 5; i++)
                arr_testFloat[i] = i + 1.1f;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr_testFloat[i]);

            Console.WriteLine();

            Console.WriteLine("string");

            arr_testString[0] = "김아무개";
            arr_testString[1] = "강아무개";
            arr_testString[2] = "감아무개";

            for (int i = 0; i < 3; i++)
                Console.WriteLine(arr_testString[i]);

            // 반복문
            // While, for문
            // do while, foreach

            // 분기문



            
        }
    }
    public class TestClass
    {

    }
}
