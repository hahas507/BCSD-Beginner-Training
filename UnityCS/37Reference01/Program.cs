using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    public int HP = 100;
    public int AT = 10;

    public void TestFunc(Player _player)
    {
        TestFuncPart1(_player);
    }

    public void TestFuncPart1(Player _player)
    {
        TestFuncPart2(_player);
    }

    public void TestFuncPart2(Player _player)
    {
        _player.AT = 20;
    }
}

namespace _37Reference01
{
    internal class Program
    {
        //배열을 인자값으로 받을수도 있다.
        private static void ArrTest(int[] _ArrTest)
        {
            _ArrTest[0] = 9999;
        }

        private static void ClassTest(Player _test)
        {
            _test.AT = 10000;
        }

        private static void ATTest(Player _test)
        {
            Console.WriteLine("공격력 테스트");
            _test.AT = 10000;
        }

        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.AT = 50;

            NewPlayer.TestFunc(null);

            Player NewPlayer2 = NewPlayer;
            NewPlayer2.AT = 1234;

            ClassTest(NewPlayer);

            int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrTest(ArrNumber);

            ATTest(null);
        }
    }
}