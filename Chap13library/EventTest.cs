using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13library
{
    public delegate void EventHandlers(string message); //EventHandlers라는 대리자 선언
    public class EventTest
    {
    }

    public class MyModifier
    {
        public event EventHandlers SomethingHappened; // SomethingHappened라는 대리자의 객체(인스턴스) 생성 후 event 한정자로 수식
        public void DoSomething(int number) //SomethingHappend라는 이벤트 대리자의 객체를 호출하는 메소드
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) // temp가 3,6,9 일때만 호출
            {
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
        static public void MyHandler(string message) // 대리자의 형식과 동일한 메소드
        {
            Console.WriteLine(message);
        }
    }
}
