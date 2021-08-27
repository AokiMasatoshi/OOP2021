using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-----------");

            Exercise1_2(file);
            Console.WriteLine("-----------");

           // Exercise1_3(file);
           //Console.WriteLine("-----------");
        }

        private static void Exercise1_1(string file)
        {
            var xdox = XDocument.Load(file);


            foreach (var item in xdox.Root.Elements()){
                var xname = item.Element("name");
                var xteammembers = item.Element("teammembers");
                Console.WriteLine("{0} {1}",xname.Value,xteammembers.Value);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdox = XDocument.Load(file);

            var xsamplelists = xdox.Root.Elements().OrderBy(x =>(x.Element("firstplayed")));
            foreach (var item in xsamplelists)
            {
                var xfirstplayed = item.Element("firstplayed");
                Console.WriteLine("{0} ",xfirstplayed.Value );
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdox = XDocument.Load("file");
           

        }
    }
}
