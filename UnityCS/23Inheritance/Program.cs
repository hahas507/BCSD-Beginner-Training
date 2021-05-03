using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//상속: 코드 재활용성을 향상시키기 위한 문법
//공통되는 기능을 하는 멤버변수와 멤버함수를 걷어낸다

internal class FightUnit
{
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(FightUnit _OtherUnit)
    {
    }
}

//내려준다 상속시킨다라고 말한다.
//C#에서 클래스 상속이란 오직 하나만 가능하다.
//하나의 클래스는 상속을 받고싶으면 하나의 클래스만 상속받을수 있다.
internal class Player : FightUnit /* 상속을 받았으므로 더이상 상속 불가능 */
{
    private int Lv = 1;

    private void Heal()
    {
        HP = 100;
    }
}

internal class Monster : FightUnit
{
    private int Exp = 10;
}

namespace _23Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

            NewPlayer.Damage(NewPlayer);

            //다운캐스팅, 업캐스팅 잘 모르겠음..
        }
    }
}