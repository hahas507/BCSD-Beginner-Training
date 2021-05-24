using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class GTest
{
    //자료형을 변수처럼 사용하고 싶을때
    //함수의 식별자에 <다양한 자료형을 대표할 이름>
    public static T ConsolePrint<T>(T _value)
    {
        Console.WriteLine(_value);
        return _value;
    }

    public static void Test(int _number)
    {
    }
}

internal class CashItem
{
}

internal class GameItem
{
}

//제네릭 클래스
internal class Inven<T>
{
    private T[] ArrInvenItem;

    public void ItemIn(T _Item)
    {
    }

    //private GameItem[] ArrInvenItem;
    //private CashItem[] ArrInvenItem;
}

internal class Program
{
    private static void Main(string[] args)
    {
        GTest.ConsolePrint(1000);
        GTest.ConsolePrint<float>(1.23123f); //<float> 쓸 필요 없음
        GTest.ConsolePrint<string>("test"); //<string> 쓸 필요 없음

        //위의 예시와 다르게 class의 경우에는 명시적으로 만들어줘야 함
        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();

        GameItem NewItem = new GameItem();
        CashItem NewCash = new CashItem();

        NewGameItemInven.ItemIn(NewItem);
        NewCashItemInven.ItemIn(NewCash);
    }
}