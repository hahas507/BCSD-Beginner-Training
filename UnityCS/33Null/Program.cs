using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    private int mAT;

    public int AT
    {
        get { return mAT; }
        set { mAT = value; }
    }
}

namespace _33Null
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //null = 가리키는게 없이 비워놓겠다.
            Player NewPlayer2 = null;
        }
    }
}