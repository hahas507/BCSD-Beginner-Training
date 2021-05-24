using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Node<T>
{
    public Node<T> Next;
    public Node<T> Prev;
}

internal class MyLinkList<T>
{
    public Node<T> First;
    public Node<T> Last;
}

namespace LinkedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // List = 시퀀스 배열형
            // LinkedList = 시퀀스 노드형

            // 노드를 관리해주는애
            // LinkedList<int>;
            // 노드 사이 사이를 타고다니는 클래스
            // LinkedListNode<int>;
            LinkedList<int> LList = new LinkedList<int>();

            LList.AddFirst(10);
            LList.AddFirst(33);
            LList.AddFirst(20);

            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next;

            LList.AddAfter(Cur, 999);

            for (LinkedListNode<int> StartNode = LList.First;
                null != StartNode;
                StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }

            //LinkedListNode<int> StartNode = LList.First;
        }
    }
}