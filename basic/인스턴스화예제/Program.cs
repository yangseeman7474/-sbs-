using System;

namespace 인스턴스화예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            //점연산자 (멤버)에 접근할떄 사용 , namespace안의 클래스에 접근할때 사용
            person1.age = 40;//정수형은 숫자 입력
            person1.height = 223.4f;//실수형은 숫자뒹에ㅣ f 입력
            person1.isFemale = false;//논리형은 true 또는 false
            person1.genderChar = '남';//문자형은 ''작은 따옴표안에 단일 문자
            person1.name = "김아무개";//문자열형은 ""큰 따옴표 안에 다중문자
            person1.Sayallinfo();
            Person person2 = new Person();
            person2.age = 13;//정수형은 숫자 입력
            person2.height = 123.4f;//실수형은 숫자뒹에ㅣ f 입력
            person2.isFemale = true;//논리형은 true 또는 false
            person2.genderChar = '여';//문자형은 ''작은 따옴표안에 단일 문자
            person2.name = "김아무개2";//문자열형은 ""큰 따옴표 안에 다중문자
            person2.Sayallinfo();

        }
    }
    class Person
    {
        // 접근제한자
        //public private protected
        //public 다른 클래스에서 접근가능
        //private 다른 클래스에서 접근불가능
        //protected 상속자만 접근 가능
        //아무것도 안적혀잇으면 private
        public int age; //정수형 4byte
        public float height; // 실수형 4byte
        public bool isFemale; //참거짓 1byte
        public char genderChar; //문자 하나 2byte
        public string name;//문자열 문자 갯수*2byte
        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayisFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SaygenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void Sayname()
        {
            Console.WriteLine(name);
        }
        public void Sayallinfo()
        {
            SayAge();
            SayisFemale();
            SaygenderChar();
            SayHeight();
            Sayname();
        }

    }
}
