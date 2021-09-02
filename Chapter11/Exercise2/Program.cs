using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "11_2.xml";
            
            Exercise2_1(file);
            Console.WriteLine();
            Console.WriteLine("-----------");

        }

        private static void Exercise2_1(string file)
        {
            var newfile = "newfile";
            var xdoc = XDocument.Load(file);
            var element= xdoc.Root.Elements();


        }
    }
}
