using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GTest<T>
{
    public T Data;
}

namespace DataStructEx
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> DicTest = new Dictionary<string, int>();

            //왠만하면 순회방식을 사용해라
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);

            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            //var은 그 시점에 가장 알맞은 자료형이 되어준다.
            int Number = 100;
            var AA = Number;

            //foreach는 자동적으로 반복하는 문장으로서
            //in을 통해 각 배열이든 dictionary든 list 내부의 자료를
            //그대로 순회할 수 있게 처리해 준다.
            //var은 그 시점에 가장 알맞은 자료형이 되어준다.
            //in은 자료구조에서 빼온다 라고만 이해해도 됀다.
            //foreach문은 루프에 대한 제한을 하기가 어렵다.
            foreach (var item in ListTest)
            {
                if (3 == item)
                {
                    break;
                }
                Console.WriteLine(item);
            }

            foreach (var item in LinkedListTest)
            {
                Console.WriteLine(item);
            }

            foreach (var item in DicTest)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}