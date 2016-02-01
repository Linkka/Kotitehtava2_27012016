using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava2olio27012016
{
    class Program
    {
        static void Main(string[] args)
        {
            // create CDs
            CD cd1 = new CD();
            cd1.Name = "Black Album";
            cd1.Artist = "Metallica";
            cd1.Year = 1991;
            cd1.Song = "Enter Sandman";
            cd1.Song2 = "Sad But True";
            cd1.Song3 = "Holier Than Thou";
            cd1.Song4 = "The Unforgiven";
            cd1.Song5 = "Wherever I May Roam";
            cd1.Song6 = "Don't Tread on Me";
            cd1.Song7 = "Through the Never";
            cd1.Song8 = "Nothing Else Matters";
            cd1.Song9 = "Of Wolf and Man";
            cd1.Song10 = "The God that Failed";
            cd1.Song11 = "My Friend of Misery";
            cd1.Song12 = "The Struggle Within";

            cd1.PrintData();
            Console.ReadLine();
        }
    }

}

