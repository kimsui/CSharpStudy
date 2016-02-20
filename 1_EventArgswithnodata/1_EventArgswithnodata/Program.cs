using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EventArgswithnodata
{
    public delegate void MyEventHandler(object sender, EventArgs e);
    class subscriber
    {
        public void fromyouHandler(object obj, EventArgs e)
        {
            Console.WriteLine("Class subscriber Message : {0}", e.ToString());
        }
    }

    public class publisher
    {
        public event MyEventHandler publiserEvent;
        public void fire(object obj)
        {
            if(publiserEvent != null)
            {
                EventArgs meargs = new EventArgs();
                publiserEvent(obj, meargs);
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            subscriber fy = new subscriber();
            publisher pb = new publisher();
            pb.publiserEvent += fy.fromyouHandler;
            pb.fire(pb);
            Console.ReadLine();
        }
    }
}
