using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//왜 메모리를 알아야 하는가?
//메모리란 사실 모든 프로그램의 근간이 되는 개념이기 때문이다.
//모든 프로그램은 메모리를 지불하고, 메모리의 구조를 안다는 것은 코드의 동작원리를 아는 것과같다.

internal class Player
{
    private int HP = 100;
    private int ATT = 10;

    public void Damage(int _Dmg)
    {
        //함수의 인자값은 지역변수인다
        //int _Dmg 지역변수의 특징: 함수가 끝나면 사라진다.
    }
}//객체로 만들기 전

internal class Program
{
    //이걸 메인 함수라고 한다.
    //static을 빼면 함수의 모양을 가지고 있고
    //함수
    //이곳을 시작이라고 잡은 함수
    //c#의 규칙 main 이라는 이름의 함수에서부터 시작한다.
    //함수의 실행조차 공짜가 없다.
    private static void Main()
    {
        //함수는 메모리화 되지 않는다.
        Console.WriteLine("메모리 1차 함수");

        // 지역변수 + a 로 게산되는데
        //최소한 지역변수를 다 포함할 수 있는 크기만큼의 크기가 되어야한다.
        int Value = 0;

        //객체를 만들었다 ㅡ> 메모리를 지불함
        Player NewPlayer = new Player();
        NewPlayer.Damage(10);
    }
}