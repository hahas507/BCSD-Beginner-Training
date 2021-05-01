using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    //멤버변수
    //객체가 생기면 맏르어지게 된다.
    private int HP = 100;

    public static void PVP(Player _Left, Player _Right)
    {
    }

    public static void Damage(Player _this, int _Dmg)
    {
        _this.HP -= _Dmg;
    }

    public void Heal(int _Heal)
    {
        HP += _Heal;
    }
}

namespace _16This
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            Player.Damage(NewPlayer1, 100);
        }
    }
}