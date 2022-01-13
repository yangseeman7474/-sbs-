using System;
using System.Collections.Generic;
using System.Text;

namespace horse_racing
{
    class Horse
    {
        public string name;
        public int distance;
        public bool dontMove;

        public void Run(int moveDistance)
        {
            distance += moveDistance;
        }
    }
}
