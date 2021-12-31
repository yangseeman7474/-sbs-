using System;
using System.Collections.Generic;
using System.Text;

namespace classinheritence
{
    class WhitePerson:Person
    {
        public override void Breath()
        {
            lifeTIme++;
            height += 0.00008f;
            weight += 0.00004f;
        }
    }
}
