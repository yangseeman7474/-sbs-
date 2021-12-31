using System;
using System.Collections.Generic;

namespace classinheritence
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

            BlackPerson blackperson = new BlackPerson();            
            YellowPerson yellowperson = new YellowPerson();
            WhitePerson whiteperson = new WhitePerson();

            blackperson.TwoFootWalk();
            whiteperson.TwoFootWalk();
            yellowperson.TwoFootWalk();
            //------------------------------------------------------
            iTwoFootWalker yelloperson_iTwoFootWalk = yellowperson;
            iTwoFootWalker blackperson_iTwoFootWalk = blackperson;
            iTwoFootWalker whiteperson_iTwoFootWalk = whiteperson;
            List<iTwoFootWalker> list_TwoFootWalker = new List<iTwoFootWalker>();
            list_TwoFootWalker.Add(blackperson_iTwoFootWalk);
            list_TwoFootWalker.Add(yelloperson_iTwoFootWalk);
            list_TwoFootWalker.Add(whiteperson_iTwoFootWalk);

            foreach (iTwoFootWalker twofootWalk in list_TwoFootWalker)
            {
                twofootWalk.TwoFootWalk();
            }
        }
    }
}
