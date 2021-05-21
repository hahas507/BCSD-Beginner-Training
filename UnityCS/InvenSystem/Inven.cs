using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//아이템을 담아두는 인벤토리
internal class Inven
{
    private int SelectIndex = 0;
    private char Input;

    private int ItemX;
    private int ItemY;
    private Item[] ArrItem;

    public Inven(int _X, int _Y)
    {
        if (_X < 1)
        {
            _X = 1;
        }
        if (_Y < 1)
        {
            _Y = 1;
        }

        ItemX = _X;
        ItemY = _Y;

        ArrItem = new Item[(_X * _Y)];
    }

    public void ItemIn(Item _item)
    {
        int Index = 0;

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (null == ArrItem[i])
            {
                Index = i;
                break;
            }
        }

        ArrItem[Index] = _item;
    }

    public void ItemIn(Item _item, int _order)
    {
        if (ArrItem[_order] != null)
        {
            return;
        }
        ArrItem[_order] = _item;
    }

    //public int getInput
    //{
    //    get
    //    {
    //        return SelectIndex;
    //    }
    //    set
    //    {
    //        SelectIndex = value;
    //    }
    //}

    //public void Input()
    //{
    //}

    public void MovementLoop()
    {
        if (SelectIndex < 0)
        {
            SelectIndex += (ItemX * ItemY);
        }
        else if (SelectIndex >= ArrItem.Length)
        {
            SelectIndex -= (ItemX * ItemY);
        }
    }

    public void MoveSelect(char _input)
    {
        if (Input == (char)ConsoleKey.UpArrow)
        {
            SelectIndex -= ItemX;
            MovementLoop();
        }
        else if (Input == (char)ConsoleKey.DownArrow)
        {
            SelectIndex += ItemX;
            MovementLoop();
        }
        else if (Input == (char)ConsoleKey.LeftArrow)
        {
            SelectIndex -= 1;
            MovementLoop();
        }
        else if (Input == (char)ConsoleKey.RightArrow)
        {
            SelectIndex += 1;
            MovementLoop();
        }
    }

    public void KeyInput()
    {
        ConsoleKeyInfo keyinfo = Console.ReadKey();
        switch (keyinfo.Key)
        {
            case ConsoleKey.UpArrow:
                Input = (char)ConsoleKey.UpArrow;
                MoveSelect(Input);
                return;

            case ConsoleKey.DownArrow:
                Input = (char)ConsoleKey.DownArrow;
                MoveSelect(Input);
                return;

            case ConsoleKey.LeftArrow:
                Input = (char)ConsoleKey.LeftArrow;
                MoveSelect(Input);
                return;

            case ConsoleKey.RightArrow:
                Input = (char)ConsoleKey.RightArrow;
                MoveSelect(Input);
                return;

            default:
                return;
        }
    }

    //public void SetItemSelect(int value)
    //{
    //    SelectIndex = value;
    //}

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (i != 0 && 0 == i % ItemX)
            {
                Console.WriteLine("");
            }

            if (SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if (null == ArrItem[i])
            {
                Console.Write("□");
            }
            else if (null != ArrItem[i])
            {
                Console.Write("■");
            }
        }
        Console.WriteLine();
        Console.WriteLine("현재 선택된 아이템");

        if (null != ArrItem[SelectIndex])
        {
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].Name);
            Console.WriteLine("가격 : " + ArrItem[SelectIndex].Gold);
        }
        else
        {
            Console.WriteLine("");
        }
    }
}