using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//단일 책임 원칙

internal class Player
{
    private enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE,
    }
}

internal class Inven
{
    private int SelectIndex = 0;

    public class InvenIcon
    {
        private void Select(Inven _inven)
        {
            _inven.SelectIndex = 100;
        }
    }

    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN,
    }

    private void selectMove()
    {
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        Inven NewInven = new Inven();
        Inven.INVENDIR ID = Inven.INVENDIR.ID_LEFT;

        NewInven.
    }
}