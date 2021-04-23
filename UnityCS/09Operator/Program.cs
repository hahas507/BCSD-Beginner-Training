using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    private int HP = 100;

    private void Damage(int _HP)
    {
        //연산자는 함수와 비슷하다
        int Result = 0;
        int Left = 7;
        int Right = 3;
        // = 대입연산자. 함수에서 리턴된 값이나 혹은 연산된 값을 그 값을 받을수 잇는 변수에 넣어줘라. 리터럴 값일때도 있음.
        //리턴값은 외부에 연산값이나 객체 상태값 등을 끝ㄴ고 나면 외부에 반환하는것을 말한다.
        // x = y + z 가 있을때 오른쪽인 y + z 부터 실행됨
        //연산자의 우선순의라고 한다.

        //산술연산자: 산술연산자는 */% 가 먼저 실행되고 +-가 실행된다.
        //()연산자는 연산자의 실행순서를 내가 지정해줄수 있게 된다.
        Result = Left + Right; //더하기

        Result = Left - Right; //빼기

        Result = Left * Right; //곱하기

        Result = Left / Right; //나누기

        Result = Left % Right; //나머지
        //한가지 주의할점은 나누기와 나머지는 0을 넣으면 안된다.

        //비교연산자: 비교연산자는 논리형으로 리턴이 된다.
        //논리형은 bool 이 있다.
        //bool 은 참과 거짓이 있는데, 참과 거짓이 상수화 된것이 true 와 false 이다.
        bool BResult = true;
        BResult = false;

        BResult = Left > Right; //Left가 Right보다 큰가? 참이라면 true 거짓이라면 false를 리턴하고 이걸 받을수 있는 자료형이 bool값이다.
        BResult = Left < Right; //Left가 Right보다 작은가?
        BResult = Left <= Right;//Left가 Right보다 작거나 같은가?
        BResult = Left >= Right;//Left가 Right보다 크거나 같은가?
        BResult = Left == Right;//Left가 Right와 같은가?
        BResult = Left != Right;//Left가 Right와 다른가?

        //bool 논리 연산자: 참과 거짓을 연산하는 연산자
        BResult = !true; // NOT
        BResult = true && false; // AND 모든게 참일때만
        BResult = true || false; // OR 하나라도 참일때
        BResult = true ^ false; // XOR 양쪽이 다르면 참, 같으면 거짓

        //축약 연산자
        Result = 0;
        Result = Result + 10;
        Result += 10;
        Result /= 10;
        Result *= 10;
    }
}

namespace _09Operator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}