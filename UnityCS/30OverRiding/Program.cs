using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class FightUnit
{
    protected string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(FightUnit _otherFightUnit)
    {
        Console.WriteLine(_otherFightUnit.Name + " did " + _otherFightUnit.AT + " damage.");

        HP -= _otherFightUnit.AT;
    }
}

internal class Player : FightUnit
{
    private int itemAT = 5;

    public Player(string _NAME)
    {
        Name = _NAME;
    }
}

internal class Monster : FightUnit
{
    public Monster(string _NAME)
    {
        Name = _NAME;
    }
}

namespace _30OverRiding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player("Player01");
            Monster NewMonster = new Monster("Orc");

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}