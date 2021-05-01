using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19if
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Test = 100;
            int elseifTest = 10; /* Ctrl + rr = 해당 변수 모두 변경 */

            //조건문
            if (elseifTest == 100)
            {
                Console.WriteLine("elseifTest는 100입니다");
            }
            else if (elseifTest == 10)
            {
                //위 조건이 false일때 실행
                Console.WriteLine("elseifTest는 10입니다.");
            }

            int elseTest = 5;

            if (elseTest == 10)
            {
                Console.WriteLine("elseTest는 10입니다");
            }
            else if (elseTest == 100)
            {
                Console.WriteLine("elseTest는 100입니다");
            }
            else
            {
                Console.WriteLine("연계된 모든 조건이 거짓입니다.");
            }
        }
    }
}