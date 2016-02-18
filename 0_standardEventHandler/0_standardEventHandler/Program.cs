// .Net에서 제공하는 EventHandler
// public delegate void EventHandler(object sender, EventArgs e);
// public delegate void(리턴값 void) MyEventHandler(object sender(이벤트를 발생시킨 객체 참조), MyEventArgs e(상태정보));
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgswithdata
{
    public delegate void MyEventHandler(object sender, MyEventArgs e);
    
    public class MyEventArgs : EventArgs
    {
        // 데이터를 저장할 필드
        public string strMessage;

        //생성자
        public MyEventArgs(string str)//7
        {
            strMessage = str;//8
        }
    }

    //publisher 에 등록할 fromyouHandler메서드가 정의된 클래스 정의
    class subscriber
    {
        public void fromyouHandler(object obj, MyEventArgs e)
        {
            Console.WriteLine("Class subscriber Message {0}", e.strMessage);//10
        }
    }

    //publisher 클래스 정의, publisherevent와 이벤트를 발생시키는 매서드인 fire() 메서드를 가지고 있는 
    // publisher 클래스를 다음과 같이 정의
    public class publisher
    {
        public event MyEventHandler publisherEvent;
        public void fire(object obj)
        {
            if(publisherEvent != null)//5
            {
                MyEventArgs meargs = new MyEventArgs("publisher class 에서 fire됨");//6, 8
                publisherEvent(obj, meargs); //9, 11
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            subscriber fy = new subscriber();//1
            publisher pb = new publisher();//2
            pb.publisherEvent += fy.fromyouHandler;//3

            pb.fire(pb);//4, 12
            Console.ReadLine();//13
        }
    }
}