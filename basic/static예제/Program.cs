using System;

namespace static예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "오크";
            orc1.height = 240.0f;
            Orc.typeName = "오크 타입 설계도";
            Orc.SayTypeName();
            //static 멤버(변수와 함수)는 객체 단위로 접근할수가 없다
            //static으로 정의된 클래스는 인스턴스화가 불가능하다
        }
    }
    public class Orc
    {
        public int age;
        public string name;
        public float height;
        public char genderChar;
        public bool isResting;
        public float weight;
        public void SayAllInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine($"{name}의키: {height}");
            Console.WriteLine($"{name}의몸무게: {weight}");
            Console.WriteLine($"{name}의나이: {age}");
            Console.WriteLine($"{name}의성별: {genderChar}");
            if (isResting)
            {
                Console.WriteLine($"{name}의 휴식상태: 휴식중");
            }
            else
            {
                Console.WriteLine($"{name}의 휴식상태: 일하는중");
            }
        }
        
        static public string typeName;
        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }

        public void Smash()
        {
            Console.WriteLine($"{name}이 휘둘렸다!");
        }
        public void Jump()
        {
            Console.WriteLine($"{name}가 점프했다!");
        }
        static class Person
        {
            //static class를 쓰는 이유
            //객체를 찍어내는것이아니라, 정보,기능,개념등이 유일하게 필요한 경우사용
            //
        }
    }
}
