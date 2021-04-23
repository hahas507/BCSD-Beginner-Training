using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Monster
{
    public int At = 10;
    public int HP = 100;

    public void Att(Player _Player)
    {
        _Player.HP -= At;
    }
}

internal class Player
{
    public int At = 10;
    public int HP = 100;

    //Monster _Monster 클래스가 객체화된 것을 받았다.
    public void Att(Monster _Monster)
    {
        HP -= _Monster.At;
    }
}

namespace _12Memory02_Reference_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //클래스가 객체화된 것들은 레퍼런스형이라 한다.

            //여태까지 배운 int, bool 같은 것들은 값형이라고 한다

            //값형과 레퍼런스형은 메모리의 위치와 사용법이 다르기 때문에
            //다르게 동작한다.

            Monster NewMonster = new Monster();
            Player NewPlayer = new Player();

            //플레이어가 자신의 공격력으로
            //몬스터를 때렸다.

            NewMonster.Att(NewPlayer);
            Console.WriteLine("HP:" + NewPlayer.HP);
        }
    }
}