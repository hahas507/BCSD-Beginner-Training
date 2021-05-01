using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal struct StructData /* Ctrl + Shift + u = 대문자로 변경 */
{
    //클래스와 비슷한데 안되는 것이 있다.
    //리터럴 초기화가 안된다.
    // = 100 안된다.
    //int a = 0;
    //int b = 0;

    public int a; /* 0이 기본이다 */
    public int b;
}

namespace _21Struct
{
    internal class Program
    {
        private static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }

        private static void Main(string[] args)
        {
            StructData NewData = new StructData();

            NewData.a = 10;
            NewData.b = 10;

            //참조형과 값형이 있다.
            //클래스를 객체화하면 그건 참조형

            Test(NewData);
        }
    }
}