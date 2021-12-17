using System;
using System.Collections.Generic;
using System.Text;

namespace 연산기호
{
    class 연산기호_연습
    {
        //산술연산

        //덧셈
        static public int Sum(int a,int b)
        {
            return a + b;
        }
        static public int Subtract(int a, int b)
        {
            return a - b;
        }
        static public int Divide(int a, int b)
        {
            return a / b;
        }
        static public int Multiplication(int a, int b)
        {
            return a * b;
        }
        static public int Remainder(int a, int b)
        {
            return a % b;
        }
        static public int IncrementOperation(int a)
        {
            return a++;
        }
        static public int DecreaseOperation(int a)
        {
            return a--;
        }
        static public bool Same(bool a, bool b)
        {
            return a == b;
        }
        static public bool Diffrence(bool a , bool b)
        {
            return a != b;
        }
        static public bool Big(int a , int b)
        {
            return a > b;
        }
        static public bool Small(int a, int b)
        {
            return a < b;
        }
        static public bool SameOrBig(int a, int b)
        {
            return a >= b;
        }
        static public bool SameOrSmall(int a, int b)
        {
            return a <= b;
        }
        static public int SumAndCollege(int a, int b)
        {
            return a = a + b;
        }
        static public int SubtractAndCollege(int a, int b)
        {
            return a = a - b;
        }
        static public int DivideAndCollege(int a, int b)
        {
            return a = a / b;
        }
        static public int MultiplicationAndCollege(int a, int b)
        {
            return a = a * b;
        }
        static public int RemainderAndCollege(int a, int b)
        {
            return a = a % b;
        }
    }
}
