using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//노드는 당순히 자료구조에서만 사용하는것은 아니다.
//자료구조라고 치면
//자료를 보관해야 하므로
internal class Node<T>
{
    public T Data;

    //자신안에 자기자신을 또 가지는 형태로
    //되어있는 클래스들을 노드라고 할 수가 있다.

    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _data)
    {
        Data = _data;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(12);
        Node<int> Node2 = new Node<int>(543);
        Node<int> Node3 = new Node<int>(123456);

        Node1.Next = Node2;
        Node2.Next = Node3;

        Node<int> CurNode = Node1;

        while (null != CurNode)
        {
            Console.WriteLine(CurNode.Data);
            CurNode = CurNode.Next;
        }
    }
}