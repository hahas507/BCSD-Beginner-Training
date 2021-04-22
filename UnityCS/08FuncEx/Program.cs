using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    //접근제한 지정자를 입력하지 않으면 기본(private)으로 지정된다.
    //공격력은 공격력 그 자체만으로 의미가 있지만
    //그 의미가 명확해지지 않는다.
    //공격력이 증가한다.

    private int LV = 1;
    private int ATT = 10;
    private int HP = 100;

    //플레이어의 레벨이 얼마인지 알고싶다.
    //안자값이 아니고 리턴값을 사용해 보겠다.
    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용한다.
    //외부에 알려주는 용도로 사용되기 때문에 알려주는 순간 한수가 끝난다.
    //return이라는 문장을 사용하면
    //얼마나 많은 코다가 return 아래에 있든 함수가 종료된다.
    public int getLV()
    {
        return LV;
        //리턴을 하는순간 끝나기 때문에 아래 코드는 의미가 없는 코드이다.
        LV = 1000;
    }

    //상태라는건 멤버변수
    //어떤 상태가 변화하는 순간
    public void LVUP()
    {
        ATT = 100;
        HP = 1000;
    }

    public void SetHp(int _HP)
    {
        //내가 HP가 0이 되는 순간만 체크할수도 있고,
        //내가 100이 되는 순간만 체크할수도 있다.
        //가장 큰 핵심은 디버깅이 가능하다는것.

        HP = _HP;
    }

    //public[리턴값] Func[이름 혹은 식별자] ( )[인자값]
    //함수란 보통 클래스 외부와의 소통을 위해서 만든다.
    //(int _Dmg)를 넣는다는 것은 외부에서 한개의 int 값을 넣어서 플레이어에게 전달해 주겠다는 것
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    //인자값는 두개가 될수도 있다. 개수는 100개 이상 넣을수도 있으므로 너무 크게 신경쓰지 말자.
    public int DmgToReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }

    //일반적으로 이런 멤버변수들은 외부에서 접근하지 못하게 하는게 좋다.
}//Player가 이런 사양을 가졌다~

//함수는 보통 선언과 내용으로 나뉘게 되는데

namespace _08FuncEx
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //NewPlayer.LVUP();
            //NewPlayer.SetHp(1000);

            //이런식으로 외부의 값을 받아서
            //객체가 내부의 상태를 변화시키기 위해
            //함 수를 선언하는 경우가 많다.
            //NewPlayer.Damage1(10);
            //NewPlayer.Damage1(20);
            //NewPlayer.Damage2(10, 20);

            Console.WriteLine(NewPlayer.getLV());
            Console.WriteLine(NewPlayer.DmgToReturn(50));
        }
    }
}