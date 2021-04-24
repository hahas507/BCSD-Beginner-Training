using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//몬스터가 100마리 죽으면 뭔가를 하기로 했다.
internal class Monster
{
    private static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}

internal class Player
{
    //앞에 static이 붙은 멤버변수는 정적멤버변수라고 한다.
    //정적멤버변수는 일반멤버변수와 다르게 객체화를 하지 않고도 사용할수 있다.
    //그 사용법이 클래스의 이름만으로 사용할 수 있다
    public static int PlayerCount = 0;

    public int AT = 10;
    public int HP = 100;

    //정적멤버변수는 클래스 내부에서는 사용가능하다.
    //어떤 클래스가 공유하고 싶은 값
    //예) 몬스터 클래스, 현재 존재하는 모든 몬스터 수
    public void Setting(int _AT, int _HP)
    {
        AT = _AT;
        HP = _HP;
    }
}

namespace _13StaticVar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;
            //이런식으로 객체화를 전혀 하지 않고 사용할수 있다.
            //객체들을 통해서 정적 멤버변수를 사용할수 없다.
            //이런 정적  멤버변수는 데이터 영역에 들어가게 된다.

            //이 멤버변수라고 하는 것들은 각각 존재한다.
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            //모든 객체가 값을 공유할 필요가 있는 데이터를 정의하는데 사용한다.
            NewMonster1.Death(); // +1
            NewMonster2.Death(); // +1
            NewMonster3.Death(); // +1
                                 // =3
        }
    }
}