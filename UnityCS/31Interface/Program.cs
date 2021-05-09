using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//함수의 형태만 물려줄 수 있는 문법
//인터페이스는 함수 구현을 강제할 수 있다.
internal interface QuestUnit
{
    void Talk(QuestUnit _OtherUnit);
}

internal class FightUnit
{
    private int AT;
    private int DMG;

    public void Damage()
    {
    }
}

internal class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {
    }
}

internal class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {
    }
}

internal class Monster : FightUnit
{
}

internal class Program
{
    private static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();

        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}