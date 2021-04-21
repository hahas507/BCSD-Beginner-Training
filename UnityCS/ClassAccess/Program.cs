using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{// ㅡ> 클래스의 내부
 //객체지향의 캡슐화 은닉화를 대표하는 문법
 //접근제한 지정자이다.
 //접근제한 지정자 문법을 사용하지 않아서
 //외부에 공개하지 않기로 했다.

    //접근제한 지정자는 다음 세가지가 존재한다.

    public int HP; //공개
    protected int ATT; //자식에게만 공개
    private int DEF; //내부에만 공개

    public void Fight()
    {
        Console.WriteLine("Fight");
    }
}// ㅡ> 클래스의 끝

//클래스의 외부
namespace ClassAccess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //만들어진 객체의 내용을 사용하기 위해서는
            //객체의 "이름."을 사용한다

            NewPlayer.HP = 0;
            NewPlayer.Fight();
        }
    }
}