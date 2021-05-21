using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34BreakContinue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (0 == i % 2)
                {
                    //만약 이 문장을 만나면 반복문의 증감문(i++)으로 바로 이동한다
                    //while 문에서도 사용가능
                    continue;
                }

                Console.WriteLine(i);
            }
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}