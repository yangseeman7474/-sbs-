using System;
using System.Collections.Generic;
using System.Text;

namespace classinheritence
{
    class Dog:Creature, iFourFootWalker
    {
        public int tailLength;

        public void FourFootWalk()
        {
            Console.WriteLine("네발로걷는다");
        }
    }
}
