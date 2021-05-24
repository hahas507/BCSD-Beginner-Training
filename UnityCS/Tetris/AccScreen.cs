using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class AccScreen : TETRISSCREEN
{
    private TETRISSCREEN Parent;

    public AccScreen(TETRISSCREEN _Parent) : base(_Parent.X, _Parent.Y - 2, false)
    {
        Parent = _Parent;
    }

    public override void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Parent.SetBlock(x, y + 1, BlockList[y][x]);
            }
        }
    }
}