using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //정규식을 표현할때 반드시 사용

namespace _04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            #region IsMatch() 메서드
            //string s = "This is your book";
            //Regex rx = new Regex("your");

            //if (rx.IsMatch(s))
            //{
            //    Console.WriteLine("일치하는 문자열이 존재합니다.");
            //}
            //else
            //{
            //    Console.WriteLine("일치하는 문자열이 없습니다.");
            //}
            //Console.ReadLine();


            //Console.WriteLine(s);
            //Console.WriteLine("01234567890123456789");
            //Regex rx = new Regex("your");

            //if(rx.IsMatch(s, 11))
            //{
            //    Console.WriteLine("일치합니다.");
            //}
            //else
            //{
            //    Console.WriteLine("일치하는 문자열이 없습니다.");
            //}


            //if (Regex.IsMatch(s,"your"))
            //{
            //    Console.WriteLine("일치하는 문자열이 있습니다.");

            //}
            //else
            //{
            //    Console.WriteLine("일치하는 문자열이 없습니다.");
            //}
            #endregion

            #region RegexOptions.None)
            string s = "This is a your book";
            string s2 = "This is my book";

            if(Regex.IsMatch(s, "Your", RegexOptions.None))
            {
                Console.WriteLine("s에 일치하는 문자열이 있습니다. ");

            }
            else
            {
                Console.WriteLine("s 에 일치하는 문자열이 없습니다. ");
            }

            if(Regex.IsMatch(s2, "My", RegexOptions.IgnoreCase))
            {
                Console.WriteLine("s2 에 일치하는 문자열이 있습니다. ");
            }
            else
            {
                Console.WriteLine("s2에 일치하는 문자열이 없습니다. ");
            }

            #endregion

            #region
            //string myOpinion = "이곳은 너무도 아름다운 곳입니다. 그렇지 않습니까?";
            //Regex r = new Regex("이곳은|저곳은");

            //if(r.IsMatch(myOpinion))
            //{
            //    Console.WriteLine("일치하는 항목이 존재합니다. ");
            //}
            //else
            //{
            //    Console.WriteLine("일치하는 항목이 존재하지 않습니다. ");
            //}
            //Console.WriteLine();
            #endregion

            #region myRegex.Match(inputString)
            //Console.WriteLine(@"이번예제는 정규표현식 '[A-Z]\d' 의 예제입니다.");
            //Console.WriteLine("테스트 할 문자열을 입력하세요");

            //string inputString;
            //inputString = Console.ReadLine();

            //Console.WriteLine("당신이 입력한 문자열: {0}", inputString);

            //Regex myRegex = new Regex(@"ABC", RegexOptions.IgnoreCase);
            //Match myMatch = myRegex.Match(inputString);

            //if (myMatch.Success)
            //    Console.WriteLine(myMatch.ToString() + "이 당신이 입력한 문자열에서 발견되었습니다.");
            //Console.ReadLine();
            #endregion

            #region 
            Console.WriteLine(@"이번예제는 정규표현식 '[A-Z]\d'의 예제입니다.");
            Console.WriteLine("테스트 할 문자열을 입력하세요.");

            string inputString;
            inputString = Console.ReadLine();
            Console.WriteLine("당신이 입력한 문자열:" + inputString);

            Regex myRegex = new Regex(@"[A-Z]\d", RegexOptions.IgnoreCase);

            MatchCollection matches = myRegex.Matches(inputString); //한꺼번에 저장
            Console.WriteLine("012345678901234567890");

            Console.WriteLine("{0} 에서 패턴과 일치 회수는 {1} 회 발생", inputString, matches.Count);
            foreach (Match match in matches)
                Console.WriteLine("'{0}'이 {1}에서 변경됨", match, match.Index);
            Console.ReadLine();
            #endregion
        }
    }
}
