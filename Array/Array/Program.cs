using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studylang = { "C#", "Java", "Scala", "PowerShell", "C", "Assembly", "XML" };
            Console.WriteLine("studylang 배열의 각 요소들의 값을 출력");
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("studylang[{0}] 에 저장된 값은 : {1}", i, studylang[i]);
            }

            // 추가된부분
            string[] copystudylang = new string[7];
            for (int i = 0; i <= 6; i++)
            {
                copystudylang[i] = studylang[i];
                Console.WriteLine("copystudylang[{0}] 에 저장된 값은 : {1} ", i, copystudylang[i]);
            }

        }
    }
}
