using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int m_MaxHP = 100;

    public int MAXHP
    {
        set
        {
            m_MaxHP = value;
        }

        get
        {
            return m_MaxHP;
        }
    }

    public bool isAlive()
    {
        return HP <= 0;
    }

    public void SetName(string _Name)
    {
        Name = _Name;
    }

    public void StatusRender()
    {
        Console.Write(Name);
        Console.WriteLine("의 능력치-----------");
        Console.WriteLine("공격력 : " + AT);
        Console.WriteLine("체력 : " + HP + "/" + m_MaxHP);
        Console.WriteLine("---------------------------");
    }

    public void Damage(FightUnit _otherUnit)
    {
        HP -= _otherUnit.AT;
    }

    public void BattleMessege(FightUnit _otherUnit)
    {
        Console.WriteLine(Name + " did " + AT + " damage to " + _otherUnit);
        Console.ReadKey();
    }
}

internal class Player : FightUnit
{
    private int Heal = 10;

    private Inven PlayerInven = new Inven(5, 3);

    public void TownHeal()
    {
        HP += Heal;
    }

    public void CheckMaxHP()
    {
        if (HP < m_MaxHP)
        {
            TownHeal();
            Console.WriteLine("체력을 " + Heal + " 회복했습니다.");
        }
        else if (HP >= m_MaxHP)
        {
            Console.WriteLine("더 이상 회복할 수 없습니다.");
        }
    }

    public Player()
    {
        Name = "Player";
    }
}

internal class Monster : FightUnit
{
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

//에러나 잘못된 선택에 대한것도 만들어야됨
internal enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT,
}

namespace TextRPG001
{
    internal class Program
    {
        //시작한다
        //마을로 갈지 싸우러 갈지
        private static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("");

            ConsoleKeyInfo CKI = Console.ReadKey();

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("");
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;

                case ConsoleKey.D2:
                    Console.WriteLine("");
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }

        private static STARTSELECT town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?.");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 상점을 방문한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("");
                        _Player.CheckMaxHP();
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        break;

                    case ConsoleKey.D3:
                        return STARTSELECT.NONESELECT;
                }
            }

            Console.ReadKey();
        }

        private static STARTSELECT battle(Player _Player)
        {
            //Console.WriteLine("아직 개장하지 않았습니다.");
            //Console.ReadKey();

            Monster NewMonster = new Monster("Orc");
            Console.Clear();
            _Player.StatusRender();
            NewMonster.StatusRender();

            while (true != NewMonster.isAlive() && true != _Player.isAlive())
            {
                Console.Clear();
                NewMonster.Damage(_Player);
                _Player.StatusRender();
                NewMonster.StatusRender();
                _Player.BattleMessege(NewMonster);

                if (NewMonster.isAlive() != true)
                {
                    Console.Clear();
                    _Player.Damage(NewMonster);
                    _Player.StatusRender();
                    NewMonster.StatusRender();
                    NewMonster.BattleMessege(_Player);
                }
            }

            if (_Player.isAlive() == true)
            {
                Console.WriteLine("Orc Win");
            }
            else
            {
                Console.WriteLine("Player Win");
            }
            Console.WriteLine("마을로 돌아갑니다.");

            Console.ReadKey();
            //town(_Player);

            return STARTSELECT.SELECTTOWN;
        }

        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //NewPlayer.SetName("Player");

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;

            while (true)
            {
                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;

                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = town(NewPlayer);
                        break;

                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = battle(NewPlayer);
                        break;
                }
            }
        }
    }
}