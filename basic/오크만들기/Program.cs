using System;

namespace 오크만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.age = 140;
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200f;
            orc1.genderChar = '남';
            orc1.isResting = false;
            orc1.SayAllInfo();
            if (orc1.isResting)
            {
                orc1.Smash();
                orc1.Jump();
            }
            else 
            {
                Console.WriteLine($"{orc1.name}은 바쁘다.");
            }

            
           

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.age = 60;
            orc2.height = 140.4f;
            orc2.weight = 120f;
            orc2.genderChar = '여';
            orc2.isResting = true;
            orc2.SayAllInfo();
            if (orc2.isResting)
            {
                orc2.Smash();
                orc2.Jump();
            }
            else
            {
                Console.WriteLine($"{orc2.name}은 바쁘다.");
            }
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
                Console.WriteLine($"{name}의 휴식상태: 휴식중" );
            }
            else
            {
                Console.WriteLine($"{name}의 휴식상태: 일하는중");
            }
        }



        public void Smash()
        {
            Console.WriteLine($"{name}이 휘둘렸다!");
        }
        public void Jump()
        {
            Console.WriteLine($"{name}가 점프했다!");
        }
        

    }
}