﻿using System;
using horse_racing;
/*
프로그램 시작시
말 다섯마리를 만들고
각 다섯마리는 초당 10~20 (정수형) 범위 거리를 랜덤하게 움직임
각각의 말이 거리 200 에 도달하면 말의 이름과 등수를 출력해줌

말은
이름, 달린거리 를 멤버변수로
달리기 를 멤버 함수로 가짐.
달리기 멤버함수는 입력받은 거리를 달린거리에 더해주어서 달린거리를 누적시키는 역할을 함.

매초 달릴 때 마다 각 말들이 얼마나 거리를 이동했는지 콘솔창에 출력해줌.
경주가 끝나면 1,2,3,4,5 등 말의 이름을 등수 순서대로 콘솔창에 출력해줌.

System.Threading namespace 에 있는 Thread.Sleep(1000); 를 사용하면 현재 프로그램을 1초 지연시킬수 있음
While 반복문에서 Thread.Sleep(1000); 을 추가하면 1초에 한번씩 반복문을 실행함.
*/
using System.Threading;
namespace UnityLesson_CSharp_HorseRacing
{

    class Program
    {
        static Random random;
        static bool isGameFinished = false;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static int finishDistance = 200;

        static void Main(string[] args)
        {
            Horse[] arr_Horse = new Horse[5];
            string[] arr_FinishedHorseName = new string[5];
            int currentGrade = 1;

            int length = arr_Horse.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Horse[i] = new Horse();
                arr_Horse[i].name = $"경주마{i + 1}";
            }
            Console.WriteLine("경주 시작!");
            int count = 0;
            while (isGameFinished == false)
            {
                Console.WriteLine($"===================== {count} 초 ====================");
                for (int i = 0; i < length; i++)
                {
                    if (arr_Horse[i].dontMove == false)
                    {
                        random = new Random();
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1);
                        arr_Horse[i].Run(tmpMoveDistance);
                        Console.WriteLine($"{arr_Horse[i].name} 가 달린거리 : {arr_Horse[i].distance}");
                        if (arr_Horse[i].distance >= finishDistance)
                        {
                            arr_Horse[i].dontMove = true;
                            arr_FinishedHorseName[currentGrade - 1] = arr_Horse[i].name;
                            currentGrade++;
                        }
                    }
                }
                Console.WriteLine($"====================================================");
                if (currentGrade > 5)
                {
                    isGameFinished = true;
                    Console.WriteLine("경주 끝!");
                    break;
                }

                Thread.Sleep(1000); // 1000 ms = 1 sec.
                count++;
            }

            Console.WriteLine("==============결과 발표==============");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1} 등 : {arr_FinishedHorseName[i]}");
            }

        }
    }
}
