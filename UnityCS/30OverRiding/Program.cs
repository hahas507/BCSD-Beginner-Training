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

    //virtual: 만약 자식에 getat가 구현되어 있다면 그쪽을 따라라
    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit GetAT");
        return AT;
    }

    public void Damage(FightUnit _otherFightUnit)
    {
        int AT = _otherFightUnit.GetAT();
        Console.WriteLine(_otherFightUnit.Name + " did " + AT + " damage.");

        HP -= AT;
    }
}

internal class Player : FightUnit
{
    private int itemAT = 5;

    public Player(string _NAME)
    {
        Name = _NAME;
    }

    //override: 나는 부모의 getat를 재구현했다.
    public override int GetAT()
    {
        Console.WriteLine("Player GetAT");
        return AT + itemAT;
    }
}

internal class Monster : FightUnit
{
    private int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("Monster의 GetAT");
        return AT + MonsterLv;
    }

    public Monster(string _NAME, int _MonsterStartLv)
    {
        Name = _NAME;
        MonsterLv = _MonsterStartLv;
    }
}

namespace _30OverRiding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player("Player01");
            Monster NewMonster = new Monster("Orc", 3);

            // NewPlayer.GetAT();
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}