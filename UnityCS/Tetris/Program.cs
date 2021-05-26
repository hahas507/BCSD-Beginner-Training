using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TETRISSCREEN NewSC = new TETRISSCREEN(10, 15, true);

            AccScreen NewASC = new AccScreen(NewSC);
            Block NewBlock = new Block(NewSC, NewASC);

            //for (int y = 0; y < 3; ++y)
            //{
            //    for (int x = 0; x < 3; ++x)
            //    {
            //        NewSC.SetBlock(y, x, TBLOCK.WALL);
            //    }
            //}

            while (true)
            {
                for (int i = 0; i < 30000000; i++)
                {
                    int a = 0;
                }
                Console.Clear();
                NewSC.Render();
                NewSC.Clear();
                NewASC.DestroyCheck();
                NewASC.Render();
                NewBlock.Move();
            }
        }
    }
}