using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    private int AT = 10;
    private int HP = 50;
    private int MaxHP = 100;
    private int Heal = 10;

    public void TownHeal()
    {
        HP += Heal;
    }

    public void CheckMaxHP()
    {
        if (HP < MaxHP)
        {
            TownHeal();
            Console.WriteLine("체력을 " + Heal + " 회복했습니다.");
        }
        else if (HP >= MaxHP)
        {
            Console.WriteLine("더 이상 회복할 수 없습니다.");
        }
    }

    public void StatusRender()
    {
        Console.WriteLine("---------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MaxHP);
        Console.Write("---------------------------");
    }
}

internal class Monster
{
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
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");

            ConsoleKeyInfo CKI = Console.ReadKey();

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;

                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;

                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }

        private static void town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?.");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        if (true)
                        {
                            _Player.CheckMaxHP();

                            Console.ReadKey();
                        }

                        break;

                    case ConsoleKey.D2:
                        break;

                    case ConsoleKey.D3:
                        return;
                }
            }

            Console.ReadKey();
        }

        private static void battle()
        {
            Console.WriteLine("아직 개장하지 않았습니다.");
            Console.ReadKey();
        }

        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        town(NewPlayer);
                        break;

                    case STARTSELECT.SELECTBATTLE:
                        battle();
                        break;
                }
            }
        }
    }
}