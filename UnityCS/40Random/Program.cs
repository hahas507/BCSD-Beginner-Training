using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Random
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random NewRandom = new Random();

            while (true)
            {
                int Random = NewRandom.Next(0, 3);
                Console.WriteLine(Random);
            }
        }
    }
}