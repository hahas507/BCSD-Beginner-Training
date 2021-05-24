using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class DicTest
{
    private Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Print(string _name)
    {
        if (false == NewDic.ContainsKey(_name))
        {
            return;
        }
        Console.WriteLine(NewDic[_name]);
    }

    public void Add(string _name, int Value)
    {
        if (true == NewDic.ContainsKey(_name))
        {
            return;
        }

        NewDic.Add(_name, Value);
    }
}

namespace Dictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DicTest NewTest = new DicTest();

            NewTest.Add("hello", 1);
            NewTest.Add("hello", 1);
            NewTest.Add("hi", 21);
            NewTest.Add("It's a key", 1);

            //Console.WriteLine(NewTest.NewDic["hi"]);

            NewTest.Print("It's a key");
        }
    }
}