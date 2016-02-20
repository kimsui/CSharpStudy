using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static int sumNumbers(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.GetUpperBound(0); i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static void PrintYourSkill(params string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            #region 배열 이름이 담고 있는 값은? 타입
            Console.WriteLine("---------------------#region 배열 이름이 담고 있는 값은? 타입---------------------");
            int[] numbers = { 234, -19, 6252, -4, 78, 2900 };
            Console.WriteLine("numbers 출력: {0}", numbers);
            Console.WriteLine("numbers Type : {0}", numbers.GetType());
            #endregion

            #region Array2
            Console.WriteLine("---------------------#region Array2---------------------");
            int[,] studentArray = { { 1, 80, 85}, {2, 90, 75 }, {3, 100, 95 }, {4, 95, 90 }, {5, 85, 90 } };

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(studentArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region 배열 선언과 초기화
            Console.WriteLine("---------------------#region 배열 선언과 초기화---------------------");

            int[,] copystudentArray = new int[5, 3];

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    copystudentArray[i, j] = studentArray[i, j];
                    Console.Write(copystudentArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            copystudentArray[2, 2] = 75;
            Console.WriteLine("copystudentArray[2,2] 을 변경한 값은 :{0} ", copystudentArray[2, 2]);
            Console.ReadLine();
            #endregion

            #region Sort() 메서드

            Console.WriteLine("배열 numbers의 차원은 {0}, 길이는 {1} 입니다.", numbers.Rank, numbers.Length);
            Console.WriteLine("\n 정렬전 numbers 배열의 요소값들을 출력");
            for(int i = 0; i< 6; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("\n\n정렬하기");

            Array.Sort(numbers);
            for (int i = 0; i < 6; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.ReadLine();

            Array.Reverse(numbers);
            for (int i = 0; i < 6; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("부분 Reverse 하기");
            Array.Reverse(numbers, 0, 4);
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write(numbers[i]+"\t");
            }

            #endregion

            #region BinarySearch()메서드
            Console.WriteLine("---------------------------#region BinarySearch()메서드---------------------------");

            object objvalue = 78;
            int returnindex;

            Console.WriteLine("\n numbers 배열의 요소값들을 출력");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(numbers[i] + "\t");
            }

            Console.WriteLine("\n\n 전체 Sort하기");
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + "\t");
            }

            Console.WriteLine("\n\n BinarySearch() 메서드 실행");
            returnindex = Array.BinarySearch(numbers, objvalue);
            Console.WriteLine("BinarySearch() 검색결과 개체 78이 발견된 인덱스 번호는 : {0}", returnindex);

            #endregion

            #region Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 22, 33 };
            jaggedArray[1] = new int[] { 22, 33, 44, 55 };
            jaggedArray[2] = new int[] { 22, 33, 44 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0}", jaggedArray[i][i] + "  ");
                }
                Console.WriteLine();
            }
            #endregion

            #region 배열을 매개리스트로, 배열을 넘기던가, 문자열들을 넘기던가,둘다 가능
            int total;
            total = sumNumbers(1, 2, 3, 4, 5);
            Console.WriteLine("ParameterArray 예제의 total 값은 : {0}", total);
            Console.ReadLine();
            #endregion

            #region 문자열 배열을 매개변수리스트로
            string[] strSkill = new string[] { "C#", "Oracle", "SQL Server", "Netwoking", "JAVA" };

            PrintYourSkill(strSkill);
            PrintYourSkill("C#", "Oracle", "SQL Server", "Netwoking", "JAVA");
            #endregion
        }
    }
}
