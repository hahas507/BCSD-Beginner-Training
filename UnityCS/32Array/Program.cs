using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private class Item
    {
        public string Name;
        public int AT;
        public int DF;
    }

    private static void Main(string[] args)
    {
        //배열은 기본자료형에 속하는 지료형이다
        //선언 방식: 어떤자료형[]

        //모든 자료형은 구조제 or 클래스에 가깝고,
        //기본자료형도 마찬가지이다.

        // ArrInt는 int의 배열형
        // ArrInt의 [0]은 무슨 자료형인가?
        int[] ArrInt = new int[10];

        for (int i = 0; i < ArrInt.Length; i++)
        {
            Console.WriteLine(ArrInt[i]);
        }

        //item이라는 참조형을 담을수 있는 공간 10개 생성.
        //item이라는 메모리를 가리킬 수 있는 참조형이 10개 생성되었다.
        Item[] ArrItem = new Item[10];

        for (int i = 0; i < ArrItem.Length; i++)
        {
            ArrItem[i] = new Item();
        }

        ArrItem[0].Name = "long sword";
        ArrItem[1].Name = "great sword";
        ArrItem[2].Name = "charge blade";
        ArrItem[3].Name = "duel blade";
        ArrItem[4].Name = "insect glaive";

        for (int i = 0; i < ArrItem.Length; i++)
        {
            Console.WriteLine(ArrItem[i].Name);
        }
    }
}