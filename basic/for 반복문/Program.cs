﻿using System;

namespace for_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_teststring = new string[3];
            //for 문
            //기본형태
            //for (인덱스용 변수 선언 및 초기화 ; for문을 실행할 조건 ; 루프가 한번 실행 될 떄마다 실행할 구문)
            //{
            //}

            string[] arr_PersonName = new string[6];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "김아무개";
            arr_PersonName[3] = "이아무개";
            arr_PersonName[4] = "김아무개";
            arr_PersonName[5] = "이아무개";
            int length = arr_PersonName.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
            //김아무개만 출력하고 싶다
            //if문 사용 예제
            for (int i = 0; i < length; i ++)
            {
                if (arr_PersonName[i] == "김아무개")
                {
                    Console.WriteLine(arr_PersonName[i]);
                }
            }
            //2n (n은 양의정수)마다 김아무개라는 규칙을 활용 예제
            for (int i = 0; i < length; i += 2)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
        }
    }
}
