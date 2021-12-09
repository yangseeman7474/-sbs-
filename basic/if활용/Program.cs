using System;

namespace if활용
{
    class Program
    {
        static bool doPrintHelloWorld = true;
        static bool doPrintSomething = true;      

        static void Main(string[] args)
        {
            //함수 호출시 함수이름();형태로 호출한다.
            if (doPrintHelloWorld == true) 
            {
                PrintHelloWorld();
            }
            else 
            {
                Console.WriteLine("do nothing");
            }
            string something = "alsjf";
            PrintSomething(something);
        }
        static void PrintHelloWorld() 
        {

            Console.WriteLine("Hello World!");
        }
        static void PrintSomething(string something) 
        {
            Console.WriteLine(something);
        }
    }
}
