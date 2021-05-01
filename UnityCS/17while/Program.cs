using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17while
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //논리형 변수(bool)가 들어감
            //어떤 함수 내에서
            //while (참/거짓)

            //while 문은 쓸때 항상 빠져나올 수 있는 조건을 넣어주고 실행해야한다(일반적인 경우에는).

            bool Check = true;

            while (Check) /*조건문*/
            {
                //실행코드
                Console.WriteLine("무한출력");
                Check = false;
            }

            int Count = 0;
            do
            {
                //실행코드
                Console.WriteLine("출력" + Count);
                Count += 1;
            } while (Count < 3); /*조건문*/
        }
    }
}