using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    public static void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    private int HP = 100;
    private int AT = 100;

    public void Damage(int _Damage)
    {
        HP -= 100;
    }

    public void Damage(Player _Other)
    {
        HP -= _Other.AT;
    }
}

namespace _14StaticFunc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            //마찬가지로 그 클래스에 속하지만
            //객체를 굳이 만들지 않고도 사용할 수 있는
            //함수를 정적멤버함수라고 한다.
            Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer1.Damage(100);
        }
    }
}

public class Monster
{
    private int AT = 10;
    //public static void PVP(Player _Left, Player _Right)
    //{
    //    _Left.HP -= _Right.AT;
    //    _Right.HP -= _Left.AT;
    //}
}