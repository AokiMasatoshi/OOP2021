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
            Console.WriteLine();
            Console.WriteLine("-----------");

            Exercise1_2(file);
            Console.WriteLine();
            Console.WriteLine("-----------");

            Exercise1_3(file);
            Console.WriteLine();
            Console.WriteLine("-----------");

            Exercise1_4(file);
            Console.WriteLine();
            Console.WriteLine("-----------");

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

            var xsamplelists = xdox.Root.Elements().OrderByDescending(x =>((string)x.Element("firstplayed")));
            foreach (var item in xsamplelists)
            {
                var xkanji = item.Element("name").Attribute("kanji");
                var xfirstplayed = item.Element("firstplayed");
                Console.WriteLine("{0} {1}",xkanji.Value ,xfirstplayed.Value);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdox = XDocument.Load(file);
            var sports = xdox.Root.Elements().Select(x => new
            {
                Name = x.Element("name").Value,
                Teammembers = x.Element("teammembers").Value
            })
                                                    .OrderByDescending(x => int.Parse(x.Teammembers))
                                                    .First();
            Console.WriteLine("{0}", sports.Name);
                                                    
        }
        private static void Exercise1_4(string file)
        {
            var newfile = "sports.xml";
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                 new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                 new XElement("teammembers", "11"),
                 new XElement("firstplayed", "1863")
              );
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
        }
    }
}
