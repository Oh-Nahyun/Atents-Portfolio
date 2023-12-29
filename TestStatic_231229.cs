using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    // static 멤버는 인스턴스화를 하지 않아도 사용할 수 있다.
    // static 멤버함수 안에서는 static 멤버가 아닌 멤버변수에 접근할 수 있다.

    class TestStatic
    {
        // static : '정적'이라는 의미. 프로그램이 실행되기 전에 메모리의 위치가 확정되어있다는 의미.

        int a = 10;
        int b = 20;

        public static int i = 0; // 인스턴스화(new)를 하지 않아도 접근할 수 있다.

        public void Test1()
        {
            Console.WriteLine("테스트1");
        }

        public static void Test2()
        {
            Console.WriteLine("테스트2");
            i = 100; // static 변수는 사용 가능. 하지만, a와 b는 불가능.
        }
    }
}
