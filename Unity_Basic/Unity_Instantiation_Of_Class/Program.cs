using System;

namespace Unity_Instantiation_Of_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            //점연산자 : 클래스의 멤버에 접급할 때 사용, namespace 안의 클래스에 접근할 때 사용
            person1.age = 40;
            person1.height = 223.4f;
            person1.isFemale = false;
            person1.genderChar = '남';
            person1.name = "김아무개";

            person1.SayAllInfo();
        }
    }
    public class Person
    {
        // 접근 제한자
        // public, private, protected
        // public 다른 클래스에서 접근가능
        // private 다른 클래스에 접근 불가능
        // protected 상속자만 접근 가능
        // 디폴트값 : private
     

        public int age;
        public float height;
        public bool isFemale;
        public char genderChar;
        public string name;

        public void SayAllInfo()
        {
            Sayage();
            SayGenderChar();
            SayHeight();
            SayIsFemale();
            Sayname();
        }


        public void Sayage()
        {
            Console.Write("나이 : ");
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void Sayname()
        {
            Console.WriteLine(name);
        }

    }
}
