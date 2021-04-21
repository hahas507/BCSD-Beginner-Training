using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    //멤버변수 ㅡ> 클래스 내부에 있다고 해서 멤버변수
    private int ATT;

    private int HP;

    private void Fight()
    {
        //선언되는 순간 지역변수는 메모리화 되고 끝날때 사라진다
        int Damage = 0;

        Console.WriteLine("Player Fight");
    }
}

namespace _06LocalVar
{
    //C#은 고지식한 객체지향 언어
    //클래스밖에 모르는 바보 ㅋㅋ
    //프로그램의 시작조차도 클래스 안에 묶어놔야 한다.
    internal class Program
    {
        //시작용 함수가 있는것이고
        private static void Main(string[] args)
        {
            //클래스 안에 있으면 멤버변수
            //함수 안에 있으면 지역변수
            //지역변수 규칙1
            //{
            //   내부에서만 사용가능.
            //}
            int ATT = 0;
            ATT = 50;

            //객체화라는 굉장히 중요한 작업
            //설계도.

            //Player의 설계대로 플레이어를 만드는데
            //그 이름을 NewPlayer 라고 한다.
            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            //Console.WriteLine("지역변수를 공부해봅시다.");
        }
    }
}