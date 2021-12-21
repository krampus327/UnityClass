using System;

namespace Unity_CSharp_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Orc[] orc_arr = new Orc[10];

            for(int i = 0;i<10;i++)
            {
                orc_arr[i] = new Orc();
                orc_arr[i].name = $"오크{i}";
            }

            //for (int i = 0; i < 10; i += 2)
            //{
            //    orc_arr[i].isResting = true;
            //}
            //for(int i = 1; i < 10; i += 2)
            //{
            //    orc_arr[i].isResting = false;
            //}
           
            for(int i = 0;i<10; i++)
            {
                orc_arr[i].isResting = GetRandomBool();
            }
            for(int i = 0; i<10;i++)
            {
                if (orc_arr[i].isResting == true)
                    orc_arr[i].Jump();
            }
        }

        static public bool GetRandomBool()
        {
            Random rand = new Random();
            bool value = Convert.ToBoolean(rand.Next(0, 2));
            return value;
        }
    }

    public class Orc

    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        public void Smash()

        {
             Console.WriteLine($"{name} (이)가 휘둘렀다!");
        }

        public void Jump()

        {
            Console.WriteLine($"{name} (이)가 점프했다!");
        }

        public void Dash()

        {
            Console.WriteLine($"{name} (이)가 돌진했다");
        }
        public void CheckIsRestingAndDash()

        {
            if (isResting)
            {
                Dash();
            }

            else
            {
                Console.WriteLine($"{name} (이)는 바빠서 돌진을 할 수가 없다");
            }
        }

    }

} 

