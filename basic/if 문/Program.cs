using System;

namespace if_문
{
    class Program
    {
        static bool condition1;
        static bool condition2;
        static bool condition3;
        static void Main(string[] args)
        {
            //if 만약에 ()안에 조건이 참이면 {}안을 실행한다
            if (condition1)
            {
                Console.WriteLine("조건1이 참");
            }
            //위의조건이 참이아니면 이조건을 비교해보겠다
            else if (condition2)
            {
                Console.WriteLine("조건1이 거짓,조건2가 참");
            }
            //모든조건이 거짓일떄 {}을실행한다
            else if (condition3)
            {
                Console.WriteLine("조건1과조건2가 거짓,조건3이참");
            }
            else
            {
                Console.WriteLine("조건1,2,3모두 거짓");
            }
        }
    }
}
