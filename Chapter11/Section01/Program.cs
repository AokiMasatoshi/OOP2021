using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdox = XDocument.Load("novelists.xml");
            //var xelements = xdox.Root.Elements()
            //    .Where(x => ((DateTime)x.Element("birth")).Year >= 1900);
            //var xelements = xdox.Root.Elements()
            //    .OrderBy(x => (string)(x.Element("birth")));


            foreach (var xnovelist in xdox.Root.Elements())
            {
                var xname = xnovelist.Element("name");
                var works = xnovelist.Element("masterpieces")
                                     .Elements("title")
                                     .Select(x=>x.Value);
                //XAttribute xkana = xname.Attribute("kana");
                //var xbirth= (DateTime)xnovelist.Element("birth");
                Console.WriteLine("{0} - {1}" ,xname.Value,string.Join(",",works));

            }
        }
    }
}
