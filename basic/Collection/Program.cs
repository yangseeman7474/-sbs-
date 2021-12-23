using System;
using System.Collections.Generic;
namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //collection은 배열과 다르게 동적 데이터 배열
            //[]배열은 갯수등을 정하면 바꿀 수 없지만 collection은 바꿀 수 있다
            
            //------------------------------------------
            //List
            //------------------------------------------
            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            //0번쨰 인덱스부터 탐색하고,첫번쨰로 인자와 같은 요소를 발견하면 삭제
            //삭제성공시 true반환, 인자와 같은 요소를 못찾으면 false반환
            _list.Remove(3);
            int length = _list.Count;
            for (int i = 0; i < length; i++)
            {
                int tmpNumber = _list[i];
                Console.WriteLine(tmpNumber);
            }

            foreach (int num in _list)
            {
                Console.WriteLine(num);
            }


            //------------------------------------------
            //Dictionary
            //------------------------------------------
            Dictionary<string,string> _dic = new Dictionary<string, string>();
            _dic.Add("검사","양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어 위주의 클래스");


            _dic.Remove("검사");
            bool isSwordMasterExist = _dic.ContainsKey("검사");
            if (isSwordMasterExist)
            {
                string tmpvalue = _dic["검사"];
                Console.WriteLine($"검사: {tmpvalue}");
            }
            else
            {
                Console.WriteLine("검사를 찾을 수 없습니다.");
            }
            foreach (string sub in _dic.Keys)
            {
                
                string tmpValue = _dic[sub];
                Console.WriteLine($"{sub}: {tmpValue}");
            }


            foreach (string sub in _dic.Values)
            {
                Console.WriteLine(sub);
            }

            foreach (KeyValuePair<string,string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey} : {tmpValue}");
            }
            



            //------------------------------------------
            //Stack
            //------------------------------------------


            //------------------------------------------
            //Queue
            //------------------------------------------
        }
    }
}
