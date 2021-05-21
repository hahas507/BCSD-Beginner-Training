using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Inven NewInven = new Inven(3, 3);
        //Keyboard NewKeyboard = new Keyboard();

        NewInven.ItemIn(new Item("철검", 100));
        NewInven.ItemIn(new Item("갑옷", 1000));
        NewInven.ItemIn(new Item("포션", 100), 5);

        while (true)
        {
            Console.Clear();
            NewInven.Render();
            //NewKeyboard.KeyInput();
            //Console.ReadKey();
            NewInven.KeyInput();
        }
    }
}