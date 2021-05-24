using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Item
{
}

internal class MyList<T>
{
    private int[] Arr = new int[0];
    private int Capa = 0;
    private int Count = 0;

    public void Add(T _add)
    {
        if (Count + 1 > Capa)
        {
            //확장
        }
    }
}

namespace List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyList<int> NewInt = new MyList<int>();

            NewInt.Add(100);

            //언어에서 지원함
            //배열형 시퀀스
            //List<Item> NewList = new List<Item>();
            //NewList.Add(1000);
            List<int> NewList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("add " + (NewList.Count + 1).ToString());
                Console.WriteLine("capacity : " + NewList.Capacity); //배열의 크기
                Console.WriteLine("count : " + NewList.Count); //자료의 크기. 자료: 넣어준 int
                Console.WriteLine("");
                NewList.Add(i);
            }

            //탐색에는 유리하지 않는 자료구조
            //인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조인다.
            //내부에 자료가 있는지없는지 확인.
            if (NewList.Contains(8))
            {
                Console.WriteLine("내부에 8이 있다!");
            }
            Console.WriteLine(NewList[5]);
        }
    }
}