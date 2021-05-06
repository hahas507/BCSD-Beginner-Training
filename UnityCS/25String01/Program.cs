using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25String01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //동적 기본자료형이다
            char Charactor = 'a';
            string Test = "";

            string Left = "hi";
            string Right = " how are u";

            string Result = Left + Right;

            Console.WriteLine(Result);
        }
    }
}