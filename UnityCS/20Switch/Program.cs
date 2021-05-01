using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int switchTest = 100;

            // ==연산밖에 못한다.
            switch (switchTest)
            {
                //case Test1: 같은 변수는 사용불가
                //오직 상수만 비교가능
                case 0:
                    Console.WriteLine("switchTest는 0입니다.");
                    break;

                case 1:
                    Console.WriteLine("switchTest는 1입니다.");
                    break;

                case 100:
                    Console.WriteLine("switchTest는 100입니다.");
                    break;

                default: /* else의 역할을 한다 */
                    Console.WriteLine("모든 조건이 맞지 않습니다.");
                    break;
            }
        }
    }
}