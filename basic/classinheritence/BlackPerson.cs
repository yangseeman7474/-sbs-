using System;
using System.Collections.Generic;
using System.Text;

namespace classinheritence
{
    class BlackPerson : Person
    {
        public override void Breath()
        {
            lifeTIme++;
            height += 0.0001f;
            weight += 0.00005f;
        }
    }
}
