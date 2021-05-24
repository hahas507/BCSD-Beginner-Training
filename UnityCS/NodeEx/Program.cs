using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Zone
{
    public string Name = "None";
    public List<Zone> LinkedZone = new List<Zone>();

    public Zone Update()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("이곳은 " + Name + " 입니다.");

            Console.WriteLine("이동할 수 있는 장소 리스트");

            for (int i = 0; i < LinkedZone.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + "." + LinkedZone[i].Name);
            }

            //형변환 가능한것이 있고 그렇지 않는것이 있다.
            //enum은 int 로 변환이 가능하다.

            int Number = (int)Console.ReadKey().Key;
            Number -= 49;
            int RealNumber = Number;

            if (LinkedZone.Count <= RealNumber)
            {
                Console.WriteLine("error");
            }
            else if (RealNumber < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                return LinkedZone[RealNumber];
            }
        }
    }

    public Zone(string _name)
    {
        Name = _name;
    }
}

namespace NodeEx
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Zone NewZone0 = new Zone("태초마을");
            Zone NewZone1 = new Zone("초보사냥터");
            Zone NewZone2 = new Zone("중급사냥터");
            Zone NewZone3 = new Zone("중급마을");
            Zone NewZone4 = new Zone("고급사냥터");

            NewZone0.LinkedZone.Add(NewZone1);
            NewZone0.LinkedZone.Add(NewZone2);

            NewZone1.LinkedZone.Add(NewZone3);

            NewZone2.LinkedZone.Add(NewZone3);

            NewZone3.LinkedZone.Add(NewZone4);

            Zone StartZone = NewZone0;

            while (true)
            {
                StartZone = StartZone.Update();
            }
        }
    }
}