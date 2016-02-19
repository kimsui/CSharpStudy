using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 49999;
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();

            #region string 클래스 속도
            //string s = string.Empty;
            //for (int i = 0; i <= counter; i++) s += i.ToString();

            //Console.WriteLine(s);
            //sw.Stop();
            //Console.WriteLine("String 클래스를 이용하여 0 부터 49999까지 출력하는데 걸린시간은 : {0} ms", sw.ElapsedMilliseconds);
            //Console.ReadLine();
            #endregion

            #region StringBuilder클래스

            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i <= counter; i++) sb.Append(i.ToString());

            //Console.WriteLine(sb.ToString());
            //sw.Stop();
            //Console.WriteLine("StringBuilder 를 이용하여 걸린시간은 : {0}ms", sw.ElapsedMilliseconds);
            //Console.ReadLine(); 
            #endregion

            #region Append()

            //StringBuilder youStringbuilder = new StringBuilder();
            //youStringbuilder.Append("Hi~ There.");
            //Console.WriteLine(youStringbuilder);

            //Console.WriteLine();
            //StringBuilder myStringBuilder = new StringBuilder("Hi,");
            //myStringBuilder.Append("What a beautiful day");
            //Console.WriteLine(myStringBuilder);

            #endregion

            #region AppendFormat()
            int intvar = 123;
            StringBuilder sb1 = new StringBuilder();
            sb1.AppendFormat("여러분이 정의한 숫자는 {0} 입니다. ", intvar);

            float myFloat = 12345.4654f;
            sb1.AppendFormat("{0, 10:f3}", myFloat);

            string mystring = "This is your book.";
            sb1.AppendFormat("추가한 데이터는 {0}", mystring);

            Console.WriteLine(sb1.ToString());
            Console.ReadLine();

            #endregion
        }
    }
}
