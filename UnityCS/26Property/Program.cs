using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Property
{
    internal class Player
    {
        private int AT = 10;
        private static int m_StaticValue = 100;

        public static int StaticValue
        {
            get
            {
                return m_StaticValue;
            }

            set
            {
                m_StaticValue = value;
            }
        }

        //자료형을 선언했다면 이는 int 와 관련된 함수라고 명시하는것.
        public int ProAT
        {
            //프로퍼티의 get 함수는 무조건 int를 리턴한다고 보고
            get
            {
                if (999 < AT)
                {
                    Console.WriteLine("Reached Maximum Value");
                    while (true)
                    {
                        Console.ReadKey();
                    }
                }
                return AT;
            }

            //무조건 int 하나가 들어온다
            //
            set
            {
                AT = value;
            }
        }

        public int GetAT()
        {
            return AT;
        }

        public void SetAT(int _Value)
        {
            if (999 < _Value)
            {
                Console.WriteLine("Reached Maximum Value");
                while (true)
                {
                    Console.ReadKey();
                }
            }
            AT = _Value;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            Player.StaticValue = 200;

            NewPlayer.ProAT = 100;
            int PlayerAT = NewPlayer.ProAT;
        }
    }
}