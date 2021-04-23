using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    private int ATT;
    private int HP;

    public int Test(int _Dmg)
    {
        //이 안에 지역변수에서 벌어지는 일은 이 안에서 벌어지는 일일 뿐이다.
        _Dmg = 1000;

        return _Dmg;
    }
}

namespace _11Memory00_Value_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //함수의 인자값
            int Value = 0;
            NewPlayer.Test(Value);

            Console.WriteLine(Value);
            //Value 값은 0이 나올것. 왜 1000이 나오지 않는가?

            //이걸 값형의 처리라고 한다.
            Value = NewPlayer.Test(Value);
        }
    }
}