using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//기본 자료형 ㅡ> 이미 있다.

//사용자 정의 자료형중 하나
//class 참조형
//struct 값형
//enum 값형

//어떤 상태를 표현하는것중
//나만의 것을 가지고 싶을때 사용한다.
internal enum ITEMTYPE
{
    EQUIP,
    POTION,
    QUEST,
    NONESELECT
}

internal class Item
{
    public ITEMTYPE itemType = ITEMTYPE.NONESELECT;
}

namespace _22Enum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.itemType = ITEMTYPE.POTION;
        }
    }
}