using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava2olio27012016
{
    class CD
    {
        // properties
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Song { get; set; }
        public string Song2 { get; set; }
        public string Song3 { get; set; }
        public string Song4 { get; set; }
        public string Song5 { get; set; }
        public string Song6 { get; set; }
        public string Song7 { get; set; }
        public string Song8 { get; set; }
        public string Song9 { get; set; }
        public string Song10 { get; set; }
        public string Song11 { get; set; }
        public string Song12 { get; set; }

        // don't create any constructor, so default one will be used

        public void PrintData()
        {
            Console.WriteLine("CD data : ");
            Console.WriteLine("- Album name : " + Name);
            Console.WriteLine("- Year : " + Year);
            Console.WriteLine("- Artist : " + Artist);
            Console.WriteLine("- Songs : " + Song);
            Console.WriteLine("---- " + Song2);
            Console.WriteLine("---- " + Song3);
            Console.WriteLine("---- " + Song4);
            Console.WriteLine("---- " + Song5);
            Console.WriteLine("---- " + Song6);
            Console.WriteLine("---- " + Song7);
            Console.WriteLine("---- " + Song8);
            Console.WriteLine("---- " + Song9);
            Console.WriteLine("---- " + Song10);
            Console.WriteLine("---- " + Song11);
            Console.WriteLine("---- " + Song12);

        }

        // destructor
        ~CD()
        {
            Console.WriteLine("CD object destroyed.");
        }

    }
}
