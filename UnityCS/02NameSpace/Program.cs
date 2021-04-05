using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//프로그래머가 2명이다.
// A프로그래머
// HP포션
// B프로그래머
// MP포션

// 클래스의 이름들은 식별자라고 한다.
// 어떤 코드적 내용을 묶는 하나의 명칭이다.

namespace APRO
{
    internal class /*APRO*/ Potion
    {
        // A프로그래머
    }
}

// 식별자가 겹칠때의 문제는 사용할때이다.
namespace BPRO
{
    internal class Potion
    {
        // B프로그래머
    }
}