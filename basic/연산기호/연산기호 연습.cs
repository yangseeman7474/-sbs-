using System;
using System.Collections.Generic;
using System.Text;

namespace 연산기호
{
    public class 연산기호_연습
    {
        //산술연산

        //덧셈
        static public int Sum(int a,int b)
        {
            return a + b;
        }
        //함수 오버로딩
        //같은 기능을 수행하는 함수의 이름을 똑같이하고
        //인수의 타입만 변경하면 같은 이름의 함수를 여러게 만들 수 있는 기능
        static public float Sum(float a, float b)
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
