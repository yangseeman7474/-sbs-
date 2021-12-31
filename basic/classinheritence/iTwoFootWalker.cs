﻿using System;
using System.Collections.Generic;
using System.Text;

namespace classinheritence
{
    //interface
    // 클래스랑 비슷하게 생겼지만
    // 함수,이벤트,인덱서,속성(Attribute)만 멤버로 가질 수 있고
    // 각 멤버는 접근권한자가 기본적으로 Public이다
    // 멤버들은 선언만 할 뿐 정의를 하지 않는다. (어떤 기능을 하는지에 대한 내용 구현이 없다)
    // 클래스와 다르게 다중상속이 가능함. (한클래스가 어려개의 인터페이스를 상속받을 수 있다)
    // 클래스의 추상화를 할떄,같은 이름이 필요한 경우 집합으로 명시하고 따로 관리할 수 있다
    //
    // 권총은 '발사'라는 기능을 가지고 있어야하고,대포도 '발사'라는 기능을 가지고 있어야하는 상황에
    // 실제 동작은 권총은 총알을 발사하고,대포는 포탄을 발사한다
    // 이렇게 각 객체가 추상화될떄 둘다 같은 이름의 기능을 가지고 있지만
    // 실제 동작은 다른경우 interface로 묶을 수 있다
    // interface도 interface를 상속받아 부모-자식 관계를 만들 수 있다
    interface iTwoFootWalker
    {
        void TwoFootWalk();
    }
}
