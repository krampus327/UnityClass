using System;

namespace Unity_CSharp_function_and_value
{
    class Program
    {
        static void Main(string[] args)
        {
            new Person();
            Person a = new Person();
            
        }
    }
    public class Person
    {
        // bit = 한자리 2진수 ( 0과1 -> 정보처리의 최소단위 )
        // byte = 8bit (cpu 데이터처리 최소단위)
        // 4바이트로 표현할 수있는 숫자의 범위 -> 2^32

        int age;
        float height;
        bool isFemale;
        char genderChar;
        string name;
     
        void SayAllInfo()
        {
            Sayage();
            SayGenderChar();
            SayHeight();
            SayIsFemale();
            Sayname();

        }
        void Sayage()
        {
            Console.WriteLine(age);
        }

        void SayHeight()
        {
            Console.WriteLine(height);
        }
        void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        void Sayname()
        {
            Console.WriteLine(name);
        }
        
    }
}