using System;

namespace 연산기호
{
    class Program
    {
        static int a =14;
        static int b = 5;
        static int c;
        static void Main(string[] args)
        {
            // 산술 연산
            // 더하기 ,빼기 ,나누기 ,곱하기 ,나머지

            // 더하기
            c= a+b;
            Console.WriteLine(c);
            //빼기
            c = a - b;
            Console.WriteLine(c);
            //나누기 ,정수로 나누기하면 결과값에서 소수값은 버린다.
            c = a / b;
            Console.WriteLine(c);
            //곱하기
            c = a * b;
            Console.WriteLine(c);
            //나머지
            c = a % b;
            Console.WriteLine(c);

            //증강연산
            //증가 연산자,감소연산자
            //증가연산
            c++;//c = c + 1;
            Console.WriteLine(c);
            //감소연산
            c--;//c = c - 1;
            Console.WriteLine(c);

            //관계연산
            //같음,다름,크기비교 연산
            //관계연산의 결과가 참이면 true 거짓이면 false를 반환

            //같음 비교
            Console.WriteLine( a == b);
            //다름 비교
            Console.WriteLine(a != b);
            //크다
            Console.WriteLine(a > b);
            //작다
            Console.WriteLine(a < b);
            //크거나같다
            Console.WriteLine(a >= b);
            //작거나같다
            Console.WriteLine(a <= b);

            //대입연산
            //더해서,빼서,나누어서,곱해서,나머지를 대입
            c = 20;
            //더해서 대입
            c += b; // c = c+b
            Console.WriteLine(c);
            //뺴서 대입
            c -= b;
            Console.WriteLine(c);
            //나누어서 대입
            c /= b;
            Console.WriteLine(c);
            //곱해서 대입
            c *= b;
            Console.WriteLine(c);
            //나머지 대입
            c %= b;
            Console.WriteLine(c);

            //논리 연산
            //양측의 피연산자들을 비교해서 연산 수행
            //or and xor not

            bool A = true;
            bool B = false;

            //or
            //a와 b 둘중 하나라도 true 이면 true
            Console.WriteLine(A | B);
            //and
            //a와 b 둘다 true 일때만 true
            Console.WriteLine(A & B);
            //xor
            //a와 b 둘중 하나만 true일때 true반환 나머지 false
            Console.WriteLine(A ^ B);
            //not
            //a의 반대 부호 반환 (true 이면 false false 이면 true)
            Console.WriteLine(!A);

            //조건부 논리연산
            //왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산한다
            //or and

            //or 조건부 연산
            //만약 A가 true이면 B의값에 관계없이 결과값이 treu이므로 
            //연산을 하지 않고 A값을 반환함
            //
            Console.WriteLine(A || B);
            //and 조건부논리연산
            //A가 false면 B의 값에 관계없이 결과값이 false이므로 연산을 하지 않고 A값을 반환함
            Console.WriteLine(A && B);

            //비트 연산
            //비트연산 하는 이유: 데이터를 효율적으로 관리하기 위함
            //or ,and ,xor ,not ,shift-left ,shift-right

            //or
            Console.WriteLine(a | b);
            //and
            Console.WriteLine(a&b);
            //xor
            Console.WriteLine(a^b);
            //not
            Console.WriteLine(~a);
            //shift-left 
            Console.WriteLine(a << 2);//2=[비트얼만큼옴길건가])
            //shift-right
            Console.WriteLine(a >> 1);//1=[비트얼만큼옴길건가)
        }
    }
}
