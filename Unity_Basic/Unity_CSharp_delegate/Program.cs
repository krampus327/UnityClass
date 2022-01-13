using System;

namespace Unirt_CSharp_delegate
{
    class Program
    {
        delegate int CalDelegate(int a, int b);
            
        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;

 /*         int sumValue;
            int subValue;
            int divValue;

            sumValue = Sum(a, b);
            subValue = Sub(a, b);
            divValue = Div(a, b);

            PrintCalc(sumValue, subValue, divValue);*/

            CalDelegate CD_Sum = Sum;
            CalDelegate CD_Sub = Sub;
            // 람다식 : 함수를 정의하지않고 연산에 필요한 내용만 표현하는 방법 객체지향이아닌 함수지향
            CalDelegate CD_Div = delegate (int a, int b)
            {
                return a / b;
            };

            

            PrintCalc(a, b, CD_Sum, CD_Sub, CD_Div);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
       


        static void PrintCalc(int a, int b, CalDelegate sum, CalDelegate sub, CalDelegate div)
        {
            Console.WriteLine($"Sum : {sum(a,b)}");
            Console.WriteLine($"Sub : {sub(a,b)}");
            Console.WriteLine($"Div : {div(a,b)}");
        }

       
    }
}