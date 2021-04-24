using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정적 클래스 static class
//정적 멤버변수 static void
//정적 멤버함수 static int 등

//정적 클래스란 정적멤버변수와 정적멤버함수만을 가질 수 있는 클래스이다.
internal static class StClass
{
    //일반적인 멤버변수는 선언만 해도 오류가 난다.
    //int TEST = 100;
}

internal class Player
{
    //위치가 어디에 있건 상관없다.
    //위치한곳이 프로그램의 시작점이 됨
    private static void Main(string[] args)
    {
        Console.WriteLine("consolewriteline은 정적멤버함수");
    }
}

namespace _15StaticClass
{
    internal class Program
    {
    }
}