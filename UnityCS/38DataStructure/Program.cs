using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료구조는 컴퓨터 과학에서 효율적인 접근 및 수정을 가능케 하는 조료의
//조직 관리 저장을 의미한다.. 더정확히 말해, 자료 구조는 데이터 값의 모임, 또 데이터 간의 관계,
//그리고 데이터에 적용할 수 있는 함수나 명령을 의미한다.

internal class MyDataStructure<T>
{
    //넣는다()
    //탐색한다()
    //확장한다()

    public void Push(T _data)
    {
        //if (이 자료가 들어왔을때 내 사이즈를 오버하면)
        //{
        //    적절한 수
        //}
    }

    public void Find(T _data)
    {
    }

    public void Expand(int _size)
    {
    }
}

namespace _38DataStructure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //자료구조는 보통 컨테이너라는 용어를 사용한다.
            //    시퀀스 컨테이너
            //    연관 컨테이너
            //    어뎁터 컨테이너
            //총 3가지로 분류한다.

            //데이터의 메모리 구조는
            //  배열
            //  노드
            //가 있다

            //자료구조이다.
            int[] Arr = new int[10];

            MyDataStructure<int> MDS = new MyDataStructure<int>();

            //100을 넣어줘
            MDS.Push(100);
            //50을 찾아줘
            MDS.Find(50);
            //넓혀줘
            MDS.Expand(1000);
        }
    }
}