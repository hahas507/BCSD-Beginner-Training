using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//보통 한글을 사용하지 않는다.
//쓸수없는것은 아니지만
//한글의 처리가 미흡한 점들이 몇몇 곳에서 있다.

//게임을 만들게 되면
//큰 개념

//RPG
//플레이어가 가질수 있느 세부적인 내용들은 무엇이 있을까?
//골드, 스테이터스, 경험치, 공격력, 방어력 등등
//명사로 표현되는 것들은 대부분 멤버 변수로 표현된다.

internal class Player
{
    //내용을 채우는 것에 대한 이야기
    //개념: 플레이어는 골드를 가진다
    //세부속성이면서 명사면서 값..

    // 멤버 변수의 선언은
    //int(자료형) 이름(식별자)
    //초기값을 넣어줄수 있다.
    //리터럴값이라고 한다.
    //선언을 함과 동시에 값을 넣어주는것을
    //리터럴 초기화라고 한다.
    //검색능력도 프로그래머의 능력

    //골드의 냅에 값이 담기게 된다.

    //1. 공짜가 없다. 무언가를 만들기 위해 메모리를 지불한다.

    //exe파일을 실행하면 이 프로그램은 램에 올라가게(복사) 된다.

    //자료형의 의미
    //크기 : x 바이트
    //형태 : 정수
    //이름의 의미
    //위치 :
    //내가 사용하기 위한 별명

    private int Gold = 10;
    private int Exp = 100;
    private int Att = 5;
    private int Def = 3;
    private int HP = 15;
}