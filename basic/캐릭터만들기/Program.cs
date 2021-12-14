using System;

namespace 캐릭터만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class person
    {
        //class function,namespace 등은 대문자로 시작한다.
        //변수는 소문자로 시작한다
        //단어가 바뀔때 첫 문자는 대문자로 시작한다.
        //줄임말은 되도록 사용하지 않는다.
        //이름을 보았을떄 어떤 기능이나 목적인지 알 수 있도록 선정한다.
        //얘매하거나 복잡한 내용이 있으면 주석을 달아준다.

        //bit = 한자리 이진수 (0과1 ,정보처리의 최소단위)
        //byte = 8 bit Cpu 데이터 처리 최소단위
        //4byte = 32bit 
        //4byte로 표현할수 있는 숫자의 범위 -> 2의32승
        int age; //정수형 4byte
        float height; // 실수형 4byte
        bool isFemale; //참거짓 1byte
        char genderChar; //문자 하나 2byte
        string name;//문자열 문자 갯수*2byte
        void SayAge() 
        {
            Console.WriteLine(age);
        }
        void SayHeight()
        {
            Console.WriteLine(height);
        }
        void SayisFemale()
        {
            Console.WriteLine(isFemale);
        }
        void SaygenderChar()
        {
            Console.WriteLine(genderChar);
        }
        void Sayname()
        {
            Console.WriteLine(name);
        }
        void Sayallinfo() 
        {
            SayAge();
            SayisFemale();
            SaygenderChar();
            SayHeight();
            Sayname();
        }
        
    }
}
