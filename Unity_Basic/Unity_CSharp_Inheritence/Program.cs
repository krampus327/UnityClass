using System;
using System.Collections.Generic;
namespace Unity_CSharp_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            creature.Breath();

            Person person = new Person();
            person.Breath();

            Dog dog = new Dog();
            dog.Breath();

            YellowMan yellowMan1 = new YellowMan();
            BlackMan blackman1 = new BlackMan();
            WhiteMan whiteMan1 = new WhiteMan();

            yellowMan1.TwoLeggedWalk();
            blackman1.TwoLeggedWalk();
            whiteMan1.TwoLeggedWalk();

            iTwoLeggedWarker yellowMan1_iTwoleggedWarker = yellowMan1;
            iTwoLeggedWarker blackMan1_iTwoleggedWarker = blackman1;
            iTwoLeggedWarker whiteman1_iTwoleggedWarker = whiteMan1;

            List<iTwoLeggedWarker> list_TwoleggedWarker = new List<iTwoLeggedWarker>();
            list_TwoleggedWarker.Add(yellowMan1_iTwoleggedWarker);
            list_TwoleggedWarker.Add(blackMan1_iTwoleggedWarker);
            list_TwoleggedWarker.Add(whiteman1_iTwoleggedWarker);

            foreach (iTwoLeggedWarker twoleggedwarker in list_TwoleggedWarker)
            {
                twoleggedwarker.TwoLeggedWalk();
            }




        }
    }
}
