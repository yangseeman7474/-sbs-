using System;

namespace 객체인스턴트화
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체생성
            //new 키워드
            new aa(); // 생성자 : 클래스이름과 똑같은 함수
            //인스턴스화
            //메모리 공간에 객체를 할당시킨다.
            //aa타입의 변수 a 에 new aa()생성된 객체가 할당 되었다.
            //이제 new aa()로 생성된 객체가 필요한때마다 변수 a를 통해서 접근할수 있게되었다.
            //그리고 이렇게 되었을떄 new aa()로 생성된 객체를 인스턴스 라고 한다.
            aa a = new aa();

        }
    }
    //클래스 (설계도)
    public class aa 
    {

    }
}
