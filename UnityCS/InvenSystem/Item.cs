using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Item
{
    private string mName;
    private int mGold;

    public string Name
    {
        get
        {
            return mName;
        }

        set
        {
            mName = value;
        }
    }

    public int Gold
    {
        get
        {
            return mGold;
        }

        set
        {
            mGold = value;
        }
    }
}