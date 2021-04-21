using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//행동에 대해서 설명해 보시오
//ex)지형 위에서~움직인다
//몬스터를~공격한다,
//npc와~대화한다

internal class Player
{
    //명사만으로는 부족하다.
    private int ATT;

    private int HP;

    //위의 예시들을 표현하는것이 멤버함수라고 한다.

    /*리턴값*/

    private void /*리턴값*/Move/*인자값*/()
    {//<-함수의 시작
    }//<-함수의 끝

    private void Fight()
    {
        // 여기를 완성하면 Fight 기능을 사용할수 있게됨
    }

    private void Talk()
    {
    }

    private void SkillUse()
    {
    }
}

//RPG게임을 만든다 ㅡ> 프로젝트를 만든다.
//주인공이 있다 ㅡ> 클래스
//주인공이 공격력이 있다 ㅡ> 멤버변수
//주인공이 공격력으로 ㅡ> 멤버함수